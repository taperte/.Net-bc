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
        public IActionResult Create(int? id)
        {
            if (!HttpContext.Session.GetIsAdmin())
            {
                return NotFound();
            }
            var model = new TopicViewModel();
            model.Topics = topics.GetAllTopics();
            //if ID is defined, a topic is being edited
            if (id.HasValue)
            {
                var data = topics.GetTopic(id.Value);
                model.Title = data.TopicName;
                model.Id = data.TopicId;
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(TopicViewModel model)
        {
            if (!HttpContext.Session.GetIsAdmin())
            {
                return NotFound();
            }
            // if valid -> save and send to another page
            if (ModelState.IsValid)
            {
                //custom validations
                try
                {
                    // manager call
                    if (model.Id == 0)
                    {
                        topics.CreateNewTopic(model.Title);
                    }
                    else
                    {
                        topics.Update(model.Id, model.Title);
                    }
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

        public IActionResult Index()
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
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (!HttpContext.Session.GetIsAdmin())
            {
                return NotFound();
            }
            //topic info from the database
            var data = topics.GetTopic(id);
            var model = new TopicViewModel();
            model.Topics = topics.GetAllTopics();

            //fill in model with data from the database
            model.Title = data.TopicName;
            model.Id = data.TopicId;

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(TopicViewModel model)
        {
            if (!HttpContext.Session.GetIsAdmin())
            {
                return NotFound();
            }
            // if valid -> save and send to another page
            if (ModelState.IsValid)
            {
                //custom validations
                try
                {
                    // manager call
                    topics.Update(model.Id, model.Title);
                    return RedirectToAction(nameof(Index));
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
