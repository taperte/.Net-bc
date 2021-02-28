﻿using System;
using System.Collections.Generic;
using System.Text;
using NewsLogic.Data;
using System.Linq;

namespace NewsLogic.Managers
{
    public class NewsManager
    {
        private List<Article> News { get; set; }

        public NewsManager()
        {
            string art01 = "At a press conferece today, January 13th 2021, the President of Latvia Quidditch Federation Ruta Knupite has announced that Riga has officially entered the competition to host Quidditch World Cup 2025. As anonymous source in World Quidditch Federation told our reporter, the chances are quite high for our fair city to host the greatest sports event of the year.";
            string art02 = "According to Wizarding Business Review, it is the first time Latvia has made Top 5 of the best countries for wizard start-ups. Three fctor were evaluated: investment climate, tax policy and the cuteness level of local kitties (needless to say, Latvian kitties are the cutest!). Great news for local business!";
            string art03 = "BREAKING NEWS: today, the infamous Azkaban escapee Sirius Black was spotted in Gulbene. Please keep your eyes open and, if you see him, please report to wizard police. And stock up on chocolate — dementors are coming to the area!";
            string art04 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer arcu tortor, tincidunt quis iaculis at, maximus non leo. Aliquam quis turpis id nisi imperdiet imperdiet. Cras venenatis molestie odio vitae interdum. Nulla dapibus nulla sed turpis rutrum, vel congue tellus pharetra. Suspendisse odio velit, convallis vitae tincidunt vitae, cursus vitae ipsum. Aliquam varius congue tellus, ac maximus sem fermentum non. Curabitur egestas nibh at odio suscipit pellentesque. Duis ultrices purus a dapibus convallis.";
            string art05 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer arcu tortor, tincidunt quis iaculis at, maximus non leo. Aliquam quis turpis id nisi imperdiet imperdiet. Cras venenatis molestie odio vitae interdum. Nulla dapibus nulla sed turpis rutrum, vel congue tellus pharetra. Suspendisse odio velit, convallis vitae tincidunt vitae, cursus vitae ipsum. Aliquam varius congue tellus, ac maximus sem fermentum non. Curabitur egestas nibh at odio suscipit pellentesque. Duis ultrices purus a dapibus convallis.";
            string art06 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer arcu tortor, tincidunt quis iaculis at, maximus non leo. Aliquam quis turpis id nisi imperdiet imperdiet. Cras venenatis molestie odio vitae interdum. Nulla dapibus nulla sed turpis rutrum, vel congue tellus pharetra. Suspendisse odio velit, convallis vitae tincidunt vitae, cursus vitae ipsum. Aliquam varius congue tellus, ac maximus sem fermentum non. Curabitur egestas nibh at odio suscipit pellentesque. Duis ultrices purus a dapibus convallis.";
            string art07 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer arcu tortor, tincidunt quis iaculis at, maximus non leo. Aliquam quis turpis id nisi imperdiet imperdiet. Cras venenatis molestie odio vitae interdum. Nulla dapibus nulla sed turpis rutrum, vel congue tellus pharetra. Suspendisse odio velit, convallis vitae tincidunt vitae, cursus vitae ipsum. Aliquam varius congue tellus, ac maximus sem fermentum non. Curabitur egestas nibh at odio suscipit pellentesque. Duis ultrices purus a dapibus convallis.";
            string art08 = "During these difficult times many of us find it difficult to maintain our beloved hobbies. This guide is for all the horcrux making enthusiasts out there! Our guest author Tom Marvolo Riddle, an experienced horcrux creator, explains how to make your own using items everyone can find at home. Great family time guaranteed!";
            string art09 = "On February 27th, The Triwizard Tournament Organizing Committee gave a press conference at the Ministry of Magic Great Conference Hall. The main announcement — for the first time in 700 years, the Tournament will take place fully online using Zoom. Special Virtual Affairs Committee was formed to adapt this inferior muggle technology to wizards' needs.";
            string art10 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer arcu tortor, tincidunt quis iaculis at, maximus non leo. Aliquam quis turpis id nisi imperdiet imperdiet. Cras venenatis molestie odio vitae interdum. Nulla dapibus nulla sed turpis rutrum, vel congue tellus pharetra. Suspendisse odio velit, convallis vitae tincidunt vitae, cursus vitae ipsum. Aliquam varius congue tellus, ac maximus sem fermentum non. Curabitur egestas nibh at odio suscipit pellentesque. Duis ultrices purus a dapibus convallis.";
            string art11 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer arcu tortor, tincidunt quis iaculis at, maximus non leo. Aliquam quis turpis id nisi imperdiet imperdiet. Cras venenatis molestie odio vitae interdum. Nulla dapibus nulla sed turpis rutrum, vel congue tellus pharetra. Suspendisse odio velit, convallis vitae tincidunt vitae, cursus vitae ipsum. Aliquam varius congue tellus, ac maximus sem fermentum non. Curabitur egestas nibh at odio suscipit pellentesque. Duis ultrices purus a dapibus convallis.";
            string art12 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer arcu tortor, tincidunt quis iaculis at, maximus non leo. Aliquam quis turpis id nisi imperdiet imperdiet. Cras venenatis molestie odio vitae interdum. Nulla dapibus nulla sed turpis rutrum, vel congue tellus pharetra. Suspendisse odio velit, convallis vitae tincidunt vitae, cursus vitae ipsum. Aliquam varius congue tellus, ac maximus sem fermentum non. Curabitur egestas nibh at odio suscipit pellentesque. Duis ultrices purus a dapibus convallis.";
            string art13 = "The night is dark and full of terrors. In the night of February 25, a group of smugglers arrested on Latvi—Belarus border with 400 l of polyjuice potion. It is the largest illegal freight confiscated in the recorded history. Investigation pending. Follow us for the latest news!";
            string art14 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer arcu tortor, tincidunt quis iaculis at, maximus non leo. Aliquam quis turpis id nisi imperdiet imperdiet. Cras venenatis molestie odio vitae interdum. Nulla dapibus nulla sed turpis rutrum, vel congue tellus pharetra. Suspendisse odio velit, convallis vitae tincidunt vitae, cursus vitae ipsum. Aliquam varius congue tellus, ac maximus sem fermentum non. Curabitur egestas nibh at odio suscipit pellentesque. Duis ultrices purus a dapibus convallis.";
            string art15 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer arcu tortor, tincidunt quis iaculis at, maximus non leo. Aliquam quis turpis id nisi imperdiet imperdiet. Cras venenatis molestie odio vitae interdum. Nulla dapibus nulla sed turpis rutrum, vel congue tellus pharetra. Suspendisse odio velit, convallis vitae tincidunt vitae, cursus vitae ipsum. Aliquam varius congue tellus, ac maximus sem fermentum non. Curabitur egestas nibh at odio suscipit pellentesque. Duis ultrices purus a dapibus convallis.";

            News = new List<Article>
            {
                new Article(1, (int)TopicName.Latvia, "Riga has good chances to host Quidditch World Cup 2025", "Ludo Bagman", art01, 2021, 01, 13, 13, 15, 03),
                new Article(2, (int)TopicName.Latvia, "Latvia in Top 5 of best countries for wizard start-ups", "Betty Braithwaite", art02, 2021, 02, 26, 21, 01, 56),
                new Article(3, (int)TopicName.Latvia, "Breaking: Sirius Black spotted in Gulbene", "Barnabas Cuffe", art03, 2021, 02, 27, 11, 46, 01),
                new Article(4, (int)TopicName.Latvia, "The Singing Sorceress' concert in Sigulda cancelled", "Winkus Oddpick", art04, 2021, 01, 29, 22, 37, 28),
                new Article(5, (int)TopicName.Latvia, "Minister of Magic visits Riga", "Winkus Oddpick", art05, 2021, 01, 25, 07, 49, 00),
                new Article(6, (int)TopicName.Latvia, "Five quidditch players arrested in Daugavpils for breaking lockdown rules", "Betty Braithwaite", art06, 2021, 02, 02, 18, 00, 00),
                new Article(7, (int)TopicName.Business, "Lean year for mandrake growers, prices have skyrocketed", "Barnabas Cuffe", art07, 2021, 02, 19, 10, 09, 25),
                new Article(8, (int)TopicName.Culture, "Hobbies during pandemic: How to create a horcrux at home", "Tom Marvolo Riddle", art08, 2021, 02, 27, 23, 15, 03),
                new Article(9, (int)TopicName.Sport, "The Triwizard Tournament 2021 to take place fully online", "Ludo Bagman", art09, 2021, 02, 27, 23, 07, 59),
                new Article(10, (int)TopicName.World, "Crime of the century? Gringotts robbed", "Zamira Gulch", art10, 2021, 02, 13, 08, 23, 23),
                new Article(11, (int)TopicName.World, "Latest news from the W8 summit: The most powerful wizards meet in London", "Zamira Gulch", art11, 2021, 01, 31, 20, 01, 38),
                new Article(12, (int)TopicName.Crime, "Death eaters go online: Cyber crime is rising during pandemic", "Dempster Wiggleswade", art12, 2021, 02, 27, 23, 35, 47),
                new Article(13, (int)TopicName.Crime, "400 l of polyjuice potion confiscated on Belarus–Latvia border", "Dempster Wiggleswade", art13, 2021, 02, 25, 10, 14, 21),
                new Article(14, (int)TopicName.Culture, "The Wizarding Wireless Network Top 100 of 2020", "Rita Skeeter", art14, 2020, 12, 31, 16, 11, 33),
                new Article(15, (int)TopicName.Culture, "The Vampire from the Valleys: Interview with Blodwyn Bludd", "Zamira Gulch", art15, 2021, 01, 28, 12, 00, 39),
            };
        }

        public List<Article> GetLatestNews(int count = 6)
        {
            return News.OrderByDescending(n => n.WhenAdded).Take(count).ToList();
        }

        public List<Article> GetNewsByTopic (int topicId)
        {
            return News.Where(n => n.TopicId == topicId).OrderByDescending(n => n.WhenAdded).ToList();
        }

        public Article GetArticle (int id)
        {
            return News.Find(n => n.Id == id);
        }

        public void PrintNews(List<Article> news, string text)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(text);
            Console.ResetColor();
            foreach (var n in news)
            {
                n.PrintArticleInfo();
            }
        }
    }
}
