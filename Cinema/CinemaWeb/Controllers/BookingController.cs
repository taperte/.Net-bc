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
        public static BookingsManager bookings = new BookingsManager();

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
            var screening = MovieController.screenings.GetScreening(screeningId);
            return RedirectToAction("Movie", "Movie", new { id = screening.MovieId });
        }

        public IActionResult Cancel(int screeningId, int seatId)
        {
            bookings.CancelABooking(screeningId, seatId);
            return RedirectToAction(nameof(MyBookings));
        }
    }
}
