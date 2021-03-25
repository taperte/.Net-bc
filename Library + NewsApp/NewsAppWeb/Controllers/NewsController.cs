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

        public IActionResult Index()
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
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Create(int? id)
        {
            if (!HttpContext.Session.GetIsAdmin())
            {
                return NotFound();
            }
            var model = new CreateArticleViewModel();
            //fills in the author name with current user's name;
            //ca be modified.
            model.Author = HttpContext.Session.GetUsername();
            model.Topics = topics.GetAllTopics();

            if (id.HasValue)
            {
                var data = articles.GetArticle(id.Value);
                model.Author = data.Author;
                model.Headline = data.Headline;
                model.Text = data.Body;
                model.Image = data.Image;
                model.Id = data.ArticleId;
                model.TopicId = data.TopicId.Value;
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CreateArticleViewModel model)
        {
            if (!HttpContext.Session.GetIsAdmin())
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    if (model.Id == 0)
                    {
                        articles.CreateNewArticle(model.TopicId, model.Headline, model.Author, model.Text, model.Image);
                    }
                    else
                    {
                        //if ID is defined, update the article
                        articles.Update(model.Id, model.TopicId, model.Headline, model.Author, model.Text, model.Image);
                    }
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
                model.Topics = topics.GetAllTopics();
            }
            return View(model);
        }
    }
}
