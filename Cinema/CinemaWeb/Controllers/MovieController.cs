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
            var allgenres = genres.GetGenres();
            var bygenre = movies.GetMoviesByGenre(genreid);
            var genresmovies = new GenreMovieViewModel()
            {
                Genres = allgenres,
                Movies = bygenre
            };
            return View(genresmovies);
        }

        public IActionResult Movie(int id)
        {
            var model = new MovieSeatsViewModel();
            model.Movie = movies.GetMovie(id);
            model.Seats = seats.GetSeats();
            model.Genres = genres.GetGenres();
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
            DateTime timeparsed = DateTime.Parse(time);
            bookings.MakeABooking(timeparsed, movieid, seatid);
            return RedirectToAction(nameof(MyBookings));
        }

        public IActionResult Cancel(string time, int movieid, int seatid)
        {
            DateTime timeparsed = DateTime.Parse(time);
            bookings.CancelABooking(timeparsed, movieid, seatid);
            return RedirectToAction(nameof(MyBookings));
        }
    }
}
