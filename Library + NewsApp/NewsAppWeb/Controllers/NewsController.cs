using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsLogic.Managers;
using NewsAppWeb.Models;
using NewsLogic;

namespace NewsAppWeb.Controllers
{
    public class NewsController : Controller
    {
        private static NewsManager articles = new NewsManager();
        private static TopicManager topics = new TopicManager();

        public IActionResult Topics(int? topicId)
        {
            var model = new TopicsViewModel();
            model.Topics = topics.GetAllTopics();
            if (topicId.HasValue)
            {
                model.Topic = topics.GetTopic(topicId.Value);
            }
            return View(model);
        }

        public IActionResult Article(int? id)
        {
            var model = new ArticleViewModel();
            if (id.HasValue)
            {
                model.Topics = topics.GetAllTopics();
                model.Article = articles.GetArticle(id.Value);
            }
            return View(model);
        }

        public IActionResult Edit()
        {
            if (!HttpContext.Session.GetIsAdmin())
            {
                return NotFound();
            }
            var allArticles = articles.GetAllArticles();
            return View(allArticles);
        }

        public IActionResult Delete(int id)
        {
            if (!HttpContext.Session.GetIsAdmin())
            {
                return NotFound();
            }
            articles.DeleteArticle(id);
            return RedirectToAction(nameof(Edit));
        }

        [HttpGet]
        public IActionResult Create()
        {
            if (!HttpContext.Session.GetIsAdmin())
            {
                return NotFound();
            }
            var model = new CreateArticleViewModel();
            model.Topics = topics.GetAllTopics();

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CreateArticleViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    articles.CreateNewArticle(model.TopicId, model.Headline, model.Author, model.Text, model.Image);
                    return RedirectToAction(nameof(Create));
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
    }
}
