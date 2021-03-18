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
        private TopicManager topics = new TopicManager();

        [HttpGet]
        public IActionResult Create()
        {
            if (!HttpContext.Session.GetIsAdmin())
            {
                return NotFound();
            }
            var model = new TopicViewModel();

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
                    topics.CreateNewTopic(model.Title);
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

        public IActionResult Edit()
        {
            if (!HttpContext.Session.GetIsAdmin())
            {
                return NotFound();
            }
            var allTopics = topics.GetAllTopics();
            return View(allTopics);
        }

        public IActionResult Delete(int id)
        {
            if (!HttpContext.Session.GetIsAdmin())
            {
                return NotFound();
            }
            topics.DeleteTopic(id);
            return RedirectToAction(nameof(Edit));
        }
    }
}
