using System;
using System.Collections.Generic;
using System.Text;
using CinemaLogic.DB;
using System.Linq;

namespace CinemaLogic.Managers
{
    public class BookingsManager
    {
        //Returns the list of bookings ordered by screening time.
        public List<Bookings> GetBookings()
        {
            using (CinemaDB db = new CinemaDB())
            {
                var bookings = db.Bookings.OrderBy(b => b.Screening.Time).ToList();
                foreach (var b in bookings)
                {
                    b.Screening = db.Screenings.FirstOrDefault(s => s.Id == b.ScreeningId);
                    b.Screening.Movie = db.Movies.FirstOrDefault(m => m.Id == b.Screening.MovieId);
                    b.Screening.Movie.Auditorium = db.Auditoriums.FirstOrDefault(a => a.Id == b.Screening.Movie.AuditoriumId);
                    b.Seat = db.Seats.FirstOrDefault(s => s.Id == b.SeatId);
                }
                return bookings;
            }
        }

        //Makes a booking at specific time; returns screening or null.
        public Screenings MakeABooking(int screeningId, int seatId, int ticketCount)
        {
            using (CinemaDB db = new CinemaDB())
            {
                //Searches for screening by screening ID.
                var screening = db.Screenings.FirstOrDefault(s => s.Id == screeningId);

                //When screening is chosen, chooses seat by ID.
                var seat = db.Seats.FirstOrDefault(s => s.Id == seatId);

                if (screening != null)
                {
                    //Fills in screening.Movie and screening.Movie.Auditorium properties.
                    screening.Movie = db.Movies.FirstOrDefault(m => m.Id == screening.MovieId);
                    screening.Movie.Auditorium = db.Auditoriums.FirstOrDefault(a => a.Id == screening.Movie.AuditoriumId);

                    //Then checks existing bookings.
                    var booking = db.Bookings.FirstOrDefault(b => b.ScreeningId == screening.Id &&
                                                                  b.SeatId == seatId);
                    //If matching booking is not found,
                    if (booking == null)
                    {
                        //a new row is added to the bookings table.
                        db.Bookings.Add(new Bookings()
                        {
                            TicketCount = ticketCount,
                            TotalPrice = screening.Movie.Price * seat.Coefficient * ticketCount,
                            SeatId = seatId,
                            Seat = seat,
                            ScreeningId = screeningId,
                            Screening = screening
                        });
                    }
                    //If a match is found,
                    else
                    {
                        //ticket count and total price are increased.
                        booking.TicketCount += ticketCount;
                        booking.TotalPrice += screening.Movie.Price * seat.Coefficient * ticketCount;
                    }
                    //Seat count is decreased.
                    switch (seatId)
                    {
                        case 1:
                            screening.BasicSeats -= ticketCount;
                            break;
                        case 2:
                            screening.Sofa -= ticketCount;
                            break;
                        default:
                            screening.Balcony -= ticketCount;
                            break;
                    }
                    //Total capacity is updated.
                    screening.TotalCapacity = TotalCapacityScreening(screening);
                    db.SaveChanges();
                    return screening;
                }
            }
            return null;
        }

        //Cancels a booking.
        public Bookings CancelABooking(int screeningId, int seatId)
        {
            using (CinemaDB db = new CinemaDB())
            {
                //Searches for the booking to cancel.
                var booking = db.Bookings.FirstOrDefault(b => b.ScreeningId == screeningId &&
                                                              b.SeatId == seatId);

                //If finds one, fills in virtual properties and checks ticket count.
                if (booking != null)
                {
                    booking.Screening = db.Screenings.FirstOrDefault(s => s.Id == booking.ScreeningId);
                    booking.Screening.Movie = db.Movies.FirstOrDefault(m => m.Id == booking.Screening.MovieId);
                    booking.Screening.Movie.Auditorium = db.Auditoriums.FirstOrDefault
                                                         (a => a.Id == booking.Screening.Movie.AuditoriumId);
                    booking.Seat = db.Seats.FirstOrDefault(s => s.Id == seatId);

                    //If there are more than 1 ticket,
                    if (booking.TicketCount > 1)
                    {
                        //ticket count and total price are decreased.
                        booking.TicketCount--;
                        booking.TotalPrice -= booking.Screening.Movie.Price * booking.Seat.Coefficient;
                    }
                    else
                    {
                        //Otherwise the booking is removed from the list.
                        db.Bookings.Remove(booking);
                    }
                    //Seat count is increased.
                    switch (seatId)
                    {
                        case 1:
                            booking.Screening.BasicSeats++;
                            break;
                        case 2:
                            booking.Screening.Sofa++;
                            break;
                        default:
                            booking.Screening.Balcony++;
                            break;
                    }

                    //Total capacity is updated.
                    booking.Screening.TotalCapacity = TotalCapacityScreening(booking.Screening);
                    db.SaveChanges();
                    return booking;
                }
            }
            return null;
        }

        //Calculates total price of all bookings.
        public decimal TotalPrice(List<Bookings> bookings)
        {
            decimal totalPrice = 0;
            foreach (var b in bookings)
            {
                totalPrice += (decimal)b.TotalPrice;
            }
            return totalPrice;
        }

        //Returns total capacity of a screening.
        private int TotalCapacityScreening(Screenings screening)
        {
            using (var db = new CinemaDB())
            {
                screening.TotalCapacity = screening.BasicSeats + screening.Sofa + screening.Balcony;
                db.SaveChanges();
                return (int)screening.TotalCapacity;
            }
        }
    }
}
