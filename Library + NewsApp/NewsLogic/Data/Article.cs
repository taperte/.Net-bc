using System;

namespace NewsLogic.Data
{
    public class Article
    {
        public int Id { get; set; }
        public Topic Topic { get; set; }
        public string Headline { get; set; }
        public string Author { get; set; }
        public string Body { get; set; }
        public DateTime WhenAdded { get; set; }

        public Article()
        {

        }

        public Article(int i, int ti, TopicName t, string h, string a, string b,
                       int y, int m, int d, int hr, int mn, int s)
        {
            Id = i;
            Headline = h;
            Author = a;
            Body = b;
            WhenAdded = new DateTime(y, m, d, hr, mn, s);
            Topic = new Topic(ti, t);
        }

        public void PrintArticleInfo()
        {
            Console.WriteLine($"{Id}. \"{Headline}\" by {Author};\ntopic: {Topic.Name}; " +
                              $"posted: {WhenAdded.ToShortDateString()} {WhenAdded.ToShortTimeString()}");
            Console.WriteLine();
        }
    }
}
