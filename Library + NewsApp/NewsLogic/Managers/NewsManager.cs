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
                var articles = db.Articles.OrderByDescending(a => a.WhenAdded).Take(count).ToList();
                foreach (var a in articles)
                {
                    a.Topic = GetTopic((int)a.TopicId);
                }
                return articles;
            }
        }

        public List<Articles> GetNewsByTopic (int topicid)
        {
            using (NewsDb db = new NewsDb())
            {
                var articles = db.Articles.Where(a => a.TopicId == topicid).
                                           OrderByDescending(a => a.WhenAdded).ToList();
                foreach (var a in articles)
                {
                    a.Topic = GetTopic((int)a.TopicId);
                }
                return articles;
            }
        }

        public Articles GetArticle (int id)
        {
            using(NewsDb db = new NewsDb())
            {
                var article = db.Articles.FirstOrDefault(a => a.ArticleId == id);
                article.Topic = GetTopic((int)article.TopicId);
                return article;
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
            Console.WriteLine($"{article.ArticleId}. \"{article.Headline}\" by {article.Author};" +
                              $"\ntopic: {topic.TopicName.ToLower()}; posted: {article.WhenAdded}");
            Console.WriteLine();
        }
    }
}
