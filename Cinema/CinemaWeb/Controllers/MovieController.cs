using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaLogic.Managers;
using CinemaWeb.Models;
using CinemaLogic;

namespace CinemaWeb.Controllers
{
    public class MovieController : Controller
    {
        public static MoviesManager movies = new MoviesManager();
        private static GenresManager genres = new GenresManager();
        private static SeatsManager seats = new SeatsManager();
        private static ScreeningsManager screenings = new ScreeningsManager();
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

        [HttpGet]
        public IActionResult Movie(int id)
        {
            ViewData["count"] = bookings.GetBookings().Count;
            var model = new MovieViewModel
            {
                Movie = movies.GetMovie(id),
                Genres = genres.GetAllGenres(),
                Prices = seats.GetSeatPrices(id),
            };
            model.AuditoriumSeats = seats.GetAuditoriumSeats(model.Movie.AuditoriumId.Value);
            return View(model);
        }

        [HttpPost]
        public IActionResult Movie(MovieViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    bookings.MakeABooking(model.SeatId, model.TicketCount);
                    return RedirectToAction("MyBookings", "Booking");
                }
                catch (LogicException ex)
                {
                    ModelState.AddModelError("validation", ex.Message);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("validation", ex.Message);
                }
            }
            var screening = screenings.GetScreeningBySeatId(model.SeatId);
            return RedirectToAction("Movie", "Movie", new { id = screening.MovieId });
        }
    }
}
