using CinemaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CinemaLogic.Managers;

namespace CinemaWeb.Controllers
{
    public class HomeController : Controller
    {
        private static BookingsManager bookings = new BookingsManager();

        public IActionResult Index()
        {
            ViewData["count"] = bookings.GetBookings().Count;
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
