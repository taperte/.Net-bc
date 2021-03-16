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
                    a.Topic = db.Topics.FirstOrDefault(t => t.TopicId == a.TopicId);
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
                    a.Topic = db.Topics.FirstOrDefault(t => t.TopicId == a.TopicId);
                }
                return articles;
            }
        }

        public Articles GetArticle (int id)
        {
            using(NewsDb db = new NewsDb())
            {
                var article = db.Articles.FirstOrDefault(a => a.ArticleId == id);
                article.Topic = db.Topics.FirstOrDefault(t => t.TopicId == article.TopicId);
                return article;
            }
        }
    }
}
