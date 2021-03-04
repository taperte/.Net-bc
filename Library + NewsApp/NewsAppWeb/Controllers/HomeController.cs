﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewsAppWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using NewsLogic.Managers;

namespace NewsAppWeb.Controllers
{
    public class HomeController : Controller
    {
        public static NewsManager editor = new NewsManager();

        public IActionResult Index()
        {
            var latestnews = editor.GetLatestNews();
            return View(latestnews);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
