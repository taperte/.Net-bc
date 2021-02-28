using System;
using NewsLogic.Data;
using NewsLogic.Managers;

namespace NewsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsManager editor = new NewsManager();
            editor.PrintNews(editor.GetLatestNews(), "Latest news:");
            editor.PrintNews(editor.GetNewsByTopic((int)TopicName.Latvia), $"{TopicName.Latvia}:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int articleid = 7;
            Console.WriteLine($"Article with ID {articleid}:");
            Console.ResetColor();
            editor.GetArticle(articleid).PrintArticleInfo();
        }
    }
}
            