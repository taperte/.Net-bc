using System;
using System.Collections.Generic;
using System.Text;

namespace NewsLogic.Data
{
    public class Article
    {
        public int Id { get; set; }
        public int TopicId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Body { get; set; }
        public DateTime WhenAdded { get; set; }

        public Article()
        {

        }

        public Article(int i, int ti, string t, string a, string b, DateTime wa)
        {

        }
    }
}
