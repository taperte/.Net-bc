using CinemaLogic.Managers;
using CinemaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb.Controllers
{
    public class BookingController : Controller
    {
        private static BookingsManager bookings = new BookingsManager();

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
            return RedirectToAction("Movie", "Movie", new { id = MovieController.movies.GetMovieIDByScreeningId(screeningId) });
        }

        public IActionResult Cancel(int screeningId, int seatId)
        {
            bookings.CancelABooking(screeningId, seatId);
            return RedirectToAction(nameof(MyBookings));
        }
    }
}
