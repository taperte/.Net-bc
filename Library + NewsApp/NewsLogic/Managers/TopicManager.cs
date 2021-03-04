using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewsLogic.DB;

namespace NewsLogic.Managers
{
    public class TopicManager
    {
        public List<Topics> GetAllTopics()
        {
            using (NewsDb db = new NewsDb())
            {
                return db.Topics.OrderBy(t => t.TopicId).ToList();
            }
        }
    }
}
