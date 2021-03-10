using System;
using CinemaLogic.Managers;

namespace CinemaConsole
{
    class Program
    {
        private static GenresManager genres = new GenresManager();
        private static MoviesManager movies = new MoviesManager();
        private static BookingsManager booking = new BookingsManager();

        static void Main(string[] args)
        {
            foreach (var g in genres.GetGenres())
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
            var time = new DateTime(2021, 3, 12, 19, 30, 0);
            var booking2  = booking.MakeABooking(time, 16);
            if (booking2 != null)
            {
                Console.WriteLine($"You've made a booking: \"{booking2.Title}\", screening time: {time}.");
            }
            else
            {
                Console.WriteLine("Booking was not made.");
            }
        }
    }
}
