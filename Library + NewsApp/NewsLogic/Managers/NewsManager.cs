using System;
using System.Collections.Generic;
using System.Text;
using NewsLogic.DB;
using System.Linq;

namespace NewsLogic.Managers
{
    public class NewsManager
    {
        public List<Articles> GetLatestNews(int count = 6)
        {
            using(NewsDb db = new NewsDb())
            {
                return db.Articles.OrderByDescending(a => a.WhenAdded).Take(count).ToList();
            }
        }

        public List<Articles> GetNewsByTopic (int topicId)
        {
            using(NewsDb db = new NewsDb())
            {
                return db.Articles.Where(a => a.TopicId == topicId).OrderByDescending(a => a.WhenAdded).ToList();
            }
        }

        public Articles GetArticle (int id)
        {
            using(NewsDb db = new NewsDb())
            {
                return db.Articles.FirstOrDefault(a => a.ArticleId == id);
            }
        }

        public Topics GetTopic(int topicid)
        {
            using (NewsDb db = new NewsDb())
            {
                return db.Topics.FirstOrDefault(t => t.TopicId == topicid);
            }
        }

        public void PrintNews(List<Articles> news, string text)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(text);
            Console.ResetColor();
            foreach (var n in news)
            {
                PrintArticleInfo(n);
            }
        }

        public void PrintArticleInfo(Articles article)
        {
            var topic = GetTopic((int)article.TopicId);
            Console.WriteLine($"{article.ArticleId}. \"{article.Headline}\" by {article.Author};\ntopic: {topic.TopicName.ToLower()}; " +
                              $"posted: {article.WhenAdded}");
            Console.WriteLine();
        }
    }
}
