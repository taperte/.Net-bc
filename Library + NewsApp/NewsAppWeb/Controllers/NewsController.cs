using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsLogic.Managers;
using NewsLogic.Data;

namespace NewsAppWeb.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Topics(int topicid)
        {
            List<Article> bytopic = HomeController.editor.GetNewsByTopic(topicid);
            return View(bytopic);
        }

        public IActionResult Article(int id)
        {
            Article article = HomeController.editor.GetArticle(id);
            return View(article);
        }
    }
}
