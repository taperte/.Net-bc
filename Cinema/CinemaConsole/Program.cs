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

            //10.03.2021. 21:00:00 12.03.2021. 19:30:00
            var time = new DateTime(2021, 3, 12, 19, 30, 0);
            var b = booking.CancelABooking(time);
            if (b != null)
            {
                Console.WriteLine($"You've cancelled a booking: \"{b.Movie.Title}\", screening time: {time}.");
            }
            else
            {
                Console.WriteLine("The booking wasn't cancelled.");
            }

            Console.WriteLine("My bookings:");
            foreach (var boo in booking.GetBookings())
            {
                Console.WriteLine($"\"{boo.Movie.Title}\", screening time: {time}");
            }
            
        }
    }
}
