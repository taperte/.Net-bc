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
        private static ScreeningsManager screenings = new ScreeningsManager();

        public IActionResult MyBookings()
        {
            ViewData["count"] = bookings.GetBookings().Count;
            var model = new MyBookingsViewModel();
            model.Bookings = bookings.GetBookings();
            model.TotalPrice = bookings.TotalPrice(model.Bookings);
            return View(model);
        }

        public IActionResult Cancel(int screeningId, int seatId)
        {
            bookings.CancelABooking(screeningId, seatId);
            return RedirectToAction(nameof(MyBookings));
        }
    }
}
