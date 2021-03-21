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
        private static SeatsManager seats = new SeatsManager();

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

            Console.WriteLine();
            Console.WriteLine("Your bookings:");
            foreach (var b in booking.GetBookings())
            {
                Console.WriteLine(b.AvailableSeats.Screening.Movie.Title);
                Console.WriteLine(b.AvailableSeats.Screening.Time);
                Console.WriteLine($"{b.TicketCount} tickets");
                Console.WriteLine($"Total price: {b.TotalPrice}");
                Console.WriteLine($"Auditorium: {b.AvailableSeats.Screening.Movie.Auditorium.Name}");
            }
            Console.WriteLine($"Available ticket count: {booking.AvailableTickets(1)}");

            
        }
    }
}
