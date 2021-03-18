using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsAppWeb.Models;
using NewsLogic;
using NewsLogic.DB;
using NewsLogic.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAppWeb.Controllers
{
    public class UserController : Controller
    {
        private UsersManager users = new UsersManager();

        [HttpGet]
        public IActionResult Register()
        {
            if (HttpContext.Session.IsLoggedIn())
            {
                return NotFound();
            }
            var model = new RegisterViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    users.Register(model.Username, model.Email, model.Password);
                    return RedirectToAction("Login");
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
            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.Session.IsLoggedIn())
            {
                return NotFound();
            }
            var model = new LoginViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = users.GetUser(model.Login, model.Password);
                if (user == null)
                {
                    ModelState.AddModelError("validation", "Incorrect login or password!");
                }
                else
                {
                    HttpContext.Session.SetUsername(user.Username);
                    HttpContext.Session.SetIsAdmin(user.IsAdmin);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
