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
                var bookings = db.Bookings.OrderBy(b => b.BookedTime).ToList();
                foreach (var b in bookings)
                {
                    b.Movie = db.Movies.FirstOrDefault(m => m.Id == b.MovieId);
                    b.Seat = db.Seats.FirstOrDefault(s => s.Id == b.SeatId);
                }
                return bookings;
            }
        }

        //Makes a booking at specific time; returns movie or null.
        public Movies MakeABooking(DateTime time, int movieid, int seatid)
        {
            using CinemaDB db = new CinemaDB();
            //Searches for screening by movie ID and screening time.
            var screening = db.Movies.FirstOrDefault(m => (m.ScreeningTime1 == time ||
                                                           m.ScreeningTime2 == time ||
                                                           m.ScreeningTime3 == time ||
                                                           m.ScreeningTime4 == time ||
                                                           m.ScreeningTime5 == time) &&
                                                           m.Id == movieid);
            //When screening is chosen, chooses seat by ID.
            var seat = db.Seats.FirstOrDefault(s => s.Id == seatid);

            if (screening != null)
            {
                //Then the program checks existing bookings.
                var booking = db.Bookings.FirstOrDefault(b => b.MovieId == screening.Id &&
                                                              b.BookedTime == time &&
                                                              b.SeatId == seatid);
                //If matching booking is not found,
                if (booking == null)
                {
                    //a new row is added to the bookings table.
                    db.Bookings.Add(new Bookings()
                    {
                        MovieId = screening.Id,
                        BookedTime = time,
                        TicketCount = 1,
                        TotalPrice = screening.Price * seat.Coefficient,
                        Movie = screening,
                        SeatId = seatid,
                        Seat = seat
                    });
                }
                //If a match is found,
                else
                {
                    //ticket count and total price are increased.
                    booking.TicketCount++;
                    booking.TotalPrice += screening.Price * seat.Coefficient;
                }
                db.SaveChanges();
            }
            return screening;
        }

        //Cancels a booking.
        public Bookings CancelABooking(DateTime time, int movieid, int seatid)
        {
            using CinemaDB db = new CinemaDB();

            //Searches for the booking to cancel.
            var booking = db.Bookings.FirstOrDefault(b => b.BookedTime == time && 
                                                          b.Id == movieid && 
                                                          b.SeatId == seatid);
            booking.Movie = db.Movies.FirstOrDefault(m => m.Id == booking.MovieId);
            booking.Seat = db.Seats.FirstOrDefault(s => s.Id == seatid);

            //If finds one, checks ticket count.
            if (booking != null)
            {
                //If there are more than 1 ticket,
                if (booking.TicketCount > 1)
                {
                    //ticket count and total price are decreased.
                    booking.TicketCount--;
                    booking.TotalPrice -= booking.Movie.Price * booking.Seat.Coefficient;
                }
                else
                {
                    //Otherwise the booking is removed from the list.
                    db.Bookings.Remove(booking);
                }
                db.SaveChanges();
            }
            return booking;
        }

        //Calculates total price of all bookings.
        public decimal TotalPrice(List<Bookings> bookings)
        {
            decimal totalprice = 0;
            foreach (var b in bookings)
            {
                totalprice += (decimal)b.TotalPrice;
            }
            return totalprice;
        }
    }
}
