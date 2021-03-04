using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsLogic.Managers;

namespace NewsAppWeb.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Topics(int topicid)
        {
            var bytopic = HomeController.editor.GetNewsByTopic(topicid);
            return View(bytopic);
        }

        public IActionResult Article(int id)
        {
            var article = HomeController.editor.GetArticle(id);
            return View(article);
        }
    }
}
