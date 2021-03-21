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
            using (var db = new CinemaDB())
            {
                var bookings = db.Bookings.ToList();

                //Virtual properties are filled.
                foreach (var b in bookings)
                {
                    BookingProperties(b);
                }
                //bookings ordered by screening time
                return bookings.OrderByDescending(b => b.AvailableSeats.Screening.Time).ToList();
            }
        }

        //seatId is the ID from AvailableSeats
        public Bookings MakeABooking(int seatId, int ticketCount)
        {
            using (var db = new CinemaDB())
            {
                //Seat type is chosen from the list of available seats.
                var seat = db.AvailableSeats.FirstOrDefault(avs => avs.Id == seatId);

                //Virtual properties are filled.
                seat.Screening = db.Screenings.FirstOrDefault(scr => scr.Id == seat.ScreeningId);
                seat.Screening.Movie = db.Movies.FirstOrDefault(m => m.Id == seat.Screening.MovieId);
                seat.AuditoriumSeats = db.AuditoriumSeats.FirstOrDefault(auds => auds.Id == seat.AuditoriumSeatsId);
                seat.AuditoriumSeats.Seat = db.Seats.FirstOrDefault(s => s.Id == seat.AuditoriumSeats.SeatId);

                if (ticketCount > seat.Count || ticketCount < 1)
                {
                    throw new LogicException("Invalid ticket count!");
                }

                //A new booking is created.
                var booking = new Bookings()
                {
                    TicketCount = ticketCount,
                    TotalPrice = seat.Screening.Movie.Price * seat.AuditoriumSeats.Seat.Coefficient * ticketCount,
                    AvailableSeatsId = seatId
                };

                //The booking is added to the db.
                db.Bookings.Add(booking);

                //Seat count is decreased.
                seat.Count -= ticketCount;

                db.SaveChanges();
                return booking;
            }
        }

        //Cancels a booking.
        public Bookings CancelABooking(int bookingId)
        {
            using (var db = new CinemaDB())
            {
                //Searches for the booking to cancel.
                var booking = db.Bookings.FirstOrDefault(b => b.Id == bookingId);

                //If finds one, screening available seat count is increased.
                var seat = db.AvailableSeats.FirstOrDefault(avs => avs.Id == booking.AvailableSeatsId);
                seat.Count += booking.TicketCount.Value;

                //The booking is removed from the db.
                db.Bookings.Remove(booking);

                db.SaveChanges();
                return booking;
            }
        }

        private void BookingProperties(Bookings booking)
        {
            using (var db = new CinemaDB())
            {
                //available seats -- a seat of a particular type at a particular screening
                booking.AvailableSeats = db.AvailableSeats
                .FirstOrDefault(avs => avs.Id == booking.AvailableSeatsId);

                //screening info
                booking.AvailableSeats.Screening = db.Screenings
                .FirstOrDefault(s => s.Id == booking.AvailableSeats.ScreeningId);

                //movie info
                booking.AvailableSeats.Screening.Movie = db.Movies
                .FirstOrDefault(m => m.Id == booking.AvailableSeats.Screening.MovieId);

                //auditorium info
                booking.AvailableSeats.Screening.Movie.Auditorium = db.Auditoriums
                .FirstOrDefault(a => a.Id == booking.AvailableSeats.Screening.Movie.AuditoriumId);
            }
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

        public int AvailableTickets(int screeningId)
        {
            using (var db = new CinemaDB())
            {
                var screening = db.Screenings.FirstOrDefault(s => s.Id == screeningId);
                var availableSeats = db.AvailableSeats.Where(avs => avs.ScreeningId == screeningId);
                int ticketCount = 0;
                foreach (var avs in availableSeats)
                {
                    avs.AuditoriumSeats = db.AuditoriumSeats.FirstOrDefault(audSeat => audSeat.Id == avs.AuditoriumSeatsId);
                    avs.AuditoriumSeats.Seat = db.Seats.FirstOrDefault(s => s.Id == avs.AuditoriumSeats.SeatId);
                    ticketCount += avs.AuditoriumSeats.SeatCount;
                }
                return ticketCount;
            }
        }
    }
}
