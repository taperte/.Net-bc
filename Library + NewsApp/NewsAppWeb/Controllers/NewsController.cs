using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsLogic.Managers;
using NewsAppWeb.Models;

namespace NewsAppWeb.Controllers
{
    public class NewsController : Controller
    {
        public static TopicManager topicEditor = new TopicManager();

        public IActionResult Topics(int? topicId)
        {
            var model = new TopicsViewModel();
            model.Topics = topicEditor.GetAllTopics();
            if (topicId.HasValue)
            {
                model.Topic = topicEditor.GetTopic(topicId.Value);
            }
            return View(model);
        }

        public IActionResult Article(int? id)
        {
            var model = new ArticleViewModel();
            if (id.HasValue)
            {
                model.Topics = topicEditor.GetAllTopics();
                model.Article = HomeController.editor.GetArticle(id.Value);
            }
            return View(model);
        }
    }
}
