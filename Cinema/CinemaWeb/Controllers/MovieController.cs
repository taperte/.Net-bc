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
        public static MoviesManager movies = new MoviesManager();
        private static GenresManager genres = new GenresManager();
        private static SeatsManager seats = new SeatsManager();
        private static ScreeningsManager screenings = new ScreeningsManager();
        private static AuditoriumsManager auditoriums = new AuditoriumsManager();
        private static BookingsManager bookings = new BookingsManager();

        public IActionResult Index()
        {
            ViewData["count"] = bookings.GetBookings().Count;
            var allMovies = movies.GetAllMovies();
            return View(allMovies);
        }

        public IActionResult Genres(int? genreId)
        {
            ViewData["count"] = bookings.GetBookings().Count;
            var model = new GenresViewModel();
            model.Genres = genres.GetAllGenres();
            if (genreId.HasValue)
            {
                model.Genre = genres.GetGenre(genreId.Value);
            }
            return View(model);
        }

        public IActionResult Movie(int id)
        {
            ViewData["count"] = bookings.GetBookings().Count;
            var model = new MovieViewModel
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
    }
}
