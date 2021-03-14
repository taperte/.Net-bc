using System;
using CinemaLogic.DB;
using CinemaLogic.Managers;
using System.Linq;

namespace CinemaConsole
{
    class Program
    {
        private static GenresManager genres = new GenresManager();
        private static MoviesManager movies = new MoviesManager();
        private static BookingsManager booking = new BookingsManager();
        private static ScreeningsManager screenings = new ScreeningsManager();

        static void Main(string[] args)
        {
            foreach (var g in genres.GetAllGenres())
            {
                Console.WriteLine(g.Genre);
            }

            foreach (var m in movies.GetMoviesByGenre(7))
            {
                Console.WriteLine(m.Title);
            }

            ////12.03.2021 21:30:00
            //var time = new DateTime(2021, 3, 12, 21, 30, 0);
            //var booking1 = booking.CancelABooking(time);
            //if (booking1 != null)
            //{
            //    Console.WriteLine($"You've cancelled a booking: \"{booking1.Movie.Title}\", screening time: {time}.");
            //}
            //else
            //{
            //    Console.WriteLine("The booking wasn't cancelled.");
            //}

            //Console.WriteLine("My bookings:");
            //foreach (var boo in booking.GetBookings())
            //{
            //    Console.WriteLine($"\"{boo.Movie.Title}\", screening time: {time}");
            //}
            //Console.WriteLine();

            //12.03.2021 19:30:00 id = 16
            //var time = new DateTime(2021, 3, 12, 19, 30, 0);
            //var booking2  = booking.MakeABooking(time, 16, 1);
            //if (booking2 != null)
            //{
            //    Console.WriteLine($"You've made a booking: \"{booking2.Title}\", screening time: {time}.");
            //}
            //else
            //{
            //    Console.WriteLine("Booking was not made.");
            //}

            //Insert values into the TotalCapacity column in the auditoriums table.
            //using (var db = new CinemaDB())
            //{
            //    var auditoriums = db.Auditoriums.OrderBy(a => a.Id).ToList();
            //    foreach (var a in auditoriums)
            //    {
            //        a.TotalCapacity = a.BasicSeats + a.Sofa + a.Balcony;
            //        var auditorium = db.Auditoriums.FirstOrDefault(aud => aud.Id == a.Id);
            //        auditorium.TotalCapacity = a.TotalCapacity;
            //    }
            //    db.SaveChanges();
            //}

            //using (var db = new CinemaDB())
            //{
            //    var screenings = db.Screenings.OrderBy(s => s.Id).ToList();
            //    foreach (var s in screenings)
            //    {
            //        s.Movie = db.Movies.FirstOrDefault(m => m.Id == s.MovieId);
            //        s.Movie.Auditorium = db.Auditoriums.FirstOrDefault(a => a.Id == s.Movie.AuditoriumId);
            //        s.BasicSeats = s.Movie.Auditorium.BasicSeats;
            //        s.Sofa = s.Movie.Auditorium.Sofa;
            //        s.Balcony = s.Movie.Auditorium.Balcony;
            //        s.TotalCapacity = s.Movie.Auditorium.TotalCapacity;
            //    }
            //    db.SaveChanges();
            //}
            foreach (var s in screenings.SeatCount(3))
            {
                Console.WriteLine(s);
            }

            foreach (var scr in screenings.SeatCountAllMovieScreenings(3))
            {
                foreach (var seatCount in scr)
                {  
                    Console.WriteLine(seatCount);
                }
            }
        }
    }
}
