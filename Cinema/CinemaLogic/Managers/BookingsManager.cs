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
            using CinemaDB db = new CinemaDB();
            var bookings = db.Bookings.OrderBy(b => b.BookedTime).ToList();
            foreach (var b in bookings)
            {
                b.Movie = db.Movies.FirstOrDefault(m => m.Id == b.MovieId);
            }
            return bookings;
        }

        //Makes a booking at specific time; returns movie or null.
        public Movies MakeABooking(DateTime time, int id)
        {
            using CinemaDB db = new CinemaDB();
            var screening = db.Movies.FirstOrDefault(m => (m.ScreeningTime1 == time ||
                                                           m.ScreeningTime2 == time ||
                                                           m.ScreeningTime3 == time ||
                                                           m.ScreeningTime4 == time ||
                                                           m.ScreeningTime5 == time) &&
                                                           m.Id == id);
            if (screening != null)
            {
                //If matching time is found, the program checks existing bookings.
                var booking = db.Bookings.FirstOrDefault(b => b.MovieId == screening.Id &&
                                                              b.BookedTime == time);
                //If matching booking is not found,
                if (booking == null)
                {
                    //new row is added to the bookings table.
                    db.Bookings.Add(new Bookings()
                    {
                        MovieId = screening.Id,
                        BookedTime = time,
                        TicketCount = 1,
                        TotalPrice = screening.Price,
                        Movie = screening
                    });
                }
                //If a match is found,
                else
                {
                    //ticket count and total price are increased.
                    booking.TicketCount++;
                    booking.TotalPrice += screening.Price;
                }
                db.SaveChanges();
            }
            return screening;
        }

        //Cancels a booking.
        public Bookings CancelABooking(DateTime time, int id)
        {
            using CinemaDB db = new CinemaDB();

            //Searches for the booking to cancel.
            var booking = db.Bookings.FirstOrDefault(b => b.BookedTime == time && b.Id == id);
            booking.Movie = db.Movies.FirstOrDefault(m => m.Id == booking.MovieId);

            //If finds one, checks ticket count.
            if (booking != null)
            {
                //If there are more than 1 ticket,
                if (booking.TicketCount > 1)
                {
                    //ticket count and total price are decreased.
                    booking.TicketCount--;
                    booking.TotalPrice -= booking.Movie.Price;
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
