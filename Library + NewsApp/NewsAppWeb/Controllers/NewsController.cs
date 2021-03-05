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
        public static TopicManager topiceditor = new TopicManager();

        public IActionResult Topics(int topicid)
        {
            var topics = topiceditor.GetAllTopics();
            var bytopic = HomeController.editor.GetNewsByTopic(topicid);
            var topicarticleviewmodel = new TopicArticleViewModel()
            { 
                Topics = topics,
                Articles = bytopic
            };
            return View(topicarticleviewmodel);
        }

        public IActionResult Article(int id)
        {
            var article = HomeController.editor.GetArticle(id);
            var topics = topiceditor.GetAllTopics();
            var topicarticleviewmodel = new TopicArticleViewModel()
            {
                Topics = topics,
                Article = article
            };
            return View(topicarticleviewmodel);
        }
    }
}
