using System;
using System.Collections.Generic;
using System.Text;

namespace NewsLogic.Data
{
    public class Article
    {
        public int Id { get; set; }
        //public int TopicID  { get; set; }
        private int topicId;

        public int TopicId
        {
            get { return topicId; }
            set { topicId = value; }
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Body { get; set; }
        public DateTime WhenAdded { get; set; }
    }
}
