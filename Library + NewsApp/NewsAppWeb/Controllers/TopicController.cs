using Microsoft.AspNetCore.Mvc;
using NewsAppWeb.Models;
using NewsLogic;
using NewsLogic.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAppWeb.Controllers
{
    public class TopicController : Controller
    {
        private TopicManager manager = new TopicManager();

        [HttpGet]
        public IActionResult Create()
        {
            var model = new TopicViewModel();
            //model.Topics = manager.GetAllTopics();

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(TopicViewModel model)
        {
            // if valid -> save and send to another page
            if (ModelState.IsValid)
            {
                //custom validations
                try
                {
                    // manager call
                    manager.CreateNewTopic(model.Title);
                    return RedirectToAction(nameof(Create));
                }
                catch (LogicException ex)
                {
                    ModelState.AddModelError("validation", ex.Message);
                }
                catch (Exception ex)
                {
                    // some other unexpected error
                    ModelState.AddModelError("validation", ex.Message);
                }
            }
            // if not valid -> return back to the same view
            return View(model);
        }
    }
}
