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
        public Movies MakeABooking(DateTime time)
        {
            using CinemaDB db = new CinemaDB();
            var screening = db.Movies.FirstOrDefault(m => m.ScreeningTime1 == time ||
                                                          m.ScreeningTime2 == time ||
                                                          m.ScreeningTime3 == time ||
                                                          m.ScreeningTime4 == time ||
                                                          m.ScreeningTime5 == time);
            if (screening != null)
            {
                //If matching time is found, new booking is added to the bookings table.
                db.Bookings.Add(new Bookings()
                {
                    MovieId = screening.Id,
                    BookedTime = time,
                    Movie = screening
                });
                db.SaveChanges();
            }
            return screening;
        }

        //Cancels a booking.
        public Bookings CancelABooking(DateTime time)
        {
            using CinemaDB db = new CinemaDB();
            var booking = db.Bookings.FirstOrDefault(b => b.BookedTime == time);
            booking.Movie = db.Movies.FirstOrDefault(m => m.Id == booking.MovieId);
            if (booking != null)
            {
                db.Bookings.Remove(booking);
                db.SaveChanges();
            }
            return booking;
        }
    }
}
