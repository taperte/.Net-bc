using System;

namespace NewsLogic.Data
{
    public class Article
    {
        public int Id { get; set; }
        private int topicId;
        public int TopicId
        {
            get { return topicId; }
            set
            {
                if (value >= 0 && value <= 5)
                {
                    topicId = value;
                }
                else
                {
                    Console.WriteLine("Invalid topic ID number! Topic ID set to 0.");
                }
            }
        }
        public string Headline { get; set; }
        public string Author { get; set; }
        public string Body { get; set; }
        public DateTime WhenAdded { get; set; }

        public Article()
        {

        }

        public Article(int i, int ti, string h, string a, string b,
                       int y, int m, int d, int hr, int mn, int s)
        {
            Id = i;
            TopicId = ti;
            Headline = h;
            Author = a;
            Body = b;
            WhenAdded = new DateTime(y, m, d, hr, mn, s);
        }

        public void PrintArticleInfo()
        {
            Console.WriteLine($"{Id}. \"{Headline}\" by {Author};\ntopic: {(TopicName)TopicId}; " +
                              $"posted: {WhenAdded.ToShortDateString()} {WhenAdded.ToShortTimeString()}");
            Console.WriteLine();
        }
    }
}
