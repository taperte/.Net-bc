using System;
using NewsLogic.Data;
using NewsLogic.Managers;
using System.Linq;

namespace NewsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsManager editor = new NewsManager();

            editor.PrintNews(editor.GetLatestNews(), "Latest news:");

            while (true)
            {
                Console.Write("Please enter topic ID or \"stop\": ");
                string input = Console.ReadLine();
                Console.WriteLine();
                if (input.ToLower() == "stop")
                {
                    break;
                }
                int topicid = int.Parse(input);
                if (topicid < 0 || topicid > 5)
                {
                    Console.Write("Invalid ID! ");
                    continue;
                }
                editor.PrintNews(editor.GetNewsByTopic(topicid), $"{(TopicName)topicid}:");
            }

            while (true)
            {
                Console.Write("Please enter article ID or \"stop\": ");
                string input = Console.ReadLine();
                Console.WriteLine();
                if (input.ToLower() == "stop")
                {
                    break;
                }
                int articleid = int.Parse(input);
                Article article = editor.GetArticle(articleid);
                if (article == null)
                {
                    Console.Write("Invalid ID! ");
                    continue;
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Article with ID {articleid}:");
                Console.ResetColor();
                article.PrintArticleInfo();
            }
        }
    }
}
            