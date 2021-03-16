using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewsLogic.DB;

namespace NewsLogic.Managers
{
    public class TopicManager
    {
        //Returns a list of all topics.
        public List<Topics> GetAllTopics()
        {
            using (NewsDb db = new NewsDb())
            {
                return db.Topics.OrderBy(t => t.TopicId).ToList();
            }
        }

        //Returns a topic by ID.
        public Topics GetTopic(int topicId)
        {
            using (NewsDb db = new NewsDb())
            {
                var topic = db.Topics.FirstOrDefault(t => t.TopicId == topicId);
                topic.Articles = db.Articles.Where(a => a.TopicId == topic.TopicId).OrderByDescending(a => a.WhenAdded).ToList();
                return topic;
            }
        }

        public void CreateNewTopic(string title)
        {
            using (var db = new NewsDb())
            {
                // logic must recheck basic validations
                // 0. Topic title must be defined
                if (string.IsNullOrEmpty(title))
                {
                    throw new LogicException("Title can't be empty!");
                }
                // 1. Topic title should be unique
                var sameTitle = db.Topics.FirstOrDefault(t => t.TopicName.ToLower() == title.ToLower());
                if (sameTitle != null)
                {
                    throw new LogicException("Topic already exists!");
                }
                db.Topics.Add(new Topics()
                {
                    TopicName = title
                });

                db.SaveChanges();
            }
        }
    }
}
