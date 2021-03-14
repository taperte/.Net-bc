using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaLogic.Managers;
using CinemaWeb.Models;

namespace CinemaWeb.Controllers
{
    public class MovieController : Controller
    {
        private static MoviesManager movies = new MoviesManager();
        private static GenresManager genres = new GenresManager();
        public static BookingsManager bookings = new BookingsManager();
        private static SeatsManager seats = new SeatsManager();
        private static ScreeningsManager screenings = new ScreeningsManager();
        private static AuditoriumsManager auditoriums = new AuditoriumsManager();

        public IActionResult Index()
        {
            var allMovies = movies.GetAllMovies();
            return View(allMovies);
        }

        public IActionResult Genres(int genreId)
        {
            var model = new GenreMovieViewModel
            {
                Genres = genres.GetAllGenres(),
                Movies = movies.GetMoviesByGenre(genreId)
            };
            return View(model);
        }

        public IActionResult Movie(int id)
        {
            var model = new MovieSeatsViewModel
            {
                Seats = seats.GetSeats(),
                Genres = genres.GetAllGenres(),
                Screenings = screenings.Screenings(id),
                Prices = seats.GetSeatPrices(id),
                ScreeningsSeatCount = screenings.SeatCountAllMovieScreenings(id),
            };
            model.Movie = movies.GetMovie(id);
            model.AuditoriumSeatCount = auditoriums.AuditoriumSeatCount((int)model.Movie.AuditoriumId);
            return View(model);
        }

        public IActionResult MyBookings()
        {
            var model = new BookingsViewModel();
            model.Bookings = bookings.GetBookings();
            model.TotalPrice = bookings.TotalPrice(model.Bookings);
            return View(model);
        }

        public IActionResult Booking(int screeningId, int seatId)
        {
            bookings.MakeABooking(screeningId, seatId);
            return RedirectToAction(nameof(Movie), new { id = movies.GetMovieIDByScreeningId(screeningId) });
        }

        public IActionResult Cancel(int screeningId, int seatId)
        {
            bookings.CancelABooking(screeningId, seatId);
            return RedirectToAction(nameof(MyBookings));
        }
    }
}
