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
        private static BookingsManager bookings = new BookingsManager();

        public IActionResult Index()
        {
            var allmovies = movies.GetAllMovies();
            return View(allmovies);
        }

        public IActionResult Genres(int genreid)
        {
            var allgenres = genres.GetGenres();
            var bygenre = movies.GetMoviesByGenre(genreid);
            var genresmovies = new GenreMovieViewModel()
            {
                Genres = allgenres,
                Movies = bygenre
            };
            return View(genresmovies);
        }

        public IActionResult MyBookings()
        {
            var mybookings = bookings.GetBookings();
            return View(mybookings);
        }

        public IActionResult Booking(string time, int id)
        {
            DateTime timeparsed = DateTime.Parse(time);
            bookings.MakeABooking(timeparsed, id);
            return RedirectToAction(nameof(MyBookings));
        }

        public IActionResult Cancel(string time, int id)
        {
            DateTime timeparsed = DateTime.Parse(time);
            bookings.CancelABooking(timeparsed, id);
            return RedirectToAction(nameof(MyBookings));
        }
    }
}
