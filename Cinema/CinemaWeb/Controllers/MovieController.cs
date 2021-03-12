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

        public IActionResult Index()
        {
            var allmovies = movies.GetAllMovies();
            return View(allmovies);
        }

        public IActionResult Genres(int genreid)
        {
            var model = new GenreMovieViewModel();
            model.Genres = genres.GetAllGenres();
            model.Movies = movies.GetMoviesByGenre(genreid);
            return View(model);
        }

        public IActionResult Movie(int id)
        {
            var model = new MovieSeatsViewModel();
            model.Movie = movies.GetMovie(id);
            model.Seats = seats.GetSeats();
            model.Genres = genres.GetAllGenres();
            model.Screenings = movies.Screenings(id);
            model.Prices = seats.GetSeatPrices(id);
            return View(model);
        }

        public IActionResult MyBookings()
        {
            var model = new BookingsViewModel();
            model.Bookings = bookings.GetBookings();
            model.TotalPrice = bookings.TotalPrice(model.Bookings);
            return View(model);
        }

        public IActionResult Booking(string time, int movieid, int seatid)
        {
            var timeparsed = DateTime.Parse(time);
            bookings.MakeABooking(timeparsed, movieid, seatid);
            return RedirectToAction("Movie", new { id = movieid });
        }

        public IActionResult Cancel(string time, int movieid, int seatid)
        {
            var timeparsed = DateTime.Parse(time);
            bookings.CancelABooking(timeparsed, movieid, seatid);
            return RedirectToAction(nameof(MyBookings));
        }
    }
}
