using System;
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
            string art03 = "BREAKING NEWS: today, the infamous Azkaban escapee Sirius Black was spotted in Gulbene. Please keep your eyes open and, if you see him, please report to the wizard police. And make sure to stock up on chocolate — dementors are coming to town!";
            string art04 = "We are sorry to announce that Celestina Warbeck, also known as The Singing Sorceress, has cancelled her concert in Sigulda, which ws long expected by many. The announcement was made as new travel restrictions came into effect. To return your tickets, please contact the organizers.";
            string art05 = "This week, British Minister of Magic is visiting Riga for the first time in history. Today busy schedule ahead — several meeting with Latvian authorities to discuss the future collaboration between to wizard nations.";
            string art06 = "Late eveing yesterday, five quidditch players were arrested in Daugavpils for breaking lockdown rules. The illegal game took place by the Stropi lake during curfew. Since the players resisted the wizard police, all of them had to spent the remaining curfew hours in jail.";
            string art07 = "Due to bad harest, there is significant mandrake shortage across Europe. Although mandrake prices have skyrocketed, growers are struggling. This morning, the Mandrake Growers Association have sent an open letter to the government requesting subsidies to be able to survive until next mandrake crop.";
            string art08 = "During these difficult times many of us find it difficult to maintain our beloved hobbies. This guide is for all the horcrux making enthusiasts out there! Our guest author Tom Marvolo Riddle, an experienced horcrux creator, explains how to make your own using items everyone can find at home. Great family time guaranteed!";
            string art09 = "On February 27th, The Triwizard Tournament Organizing Committee gave a press conference at the Ministry of Magic Great Conference Hall. The main announcement — for the first time in 700 years, the Tournament will take place fully online using Zoom. Special Virtual Affairs Committee was formed to adapt this inferior muggle technology to wizards' needs.";
            string art10 = "Breaking news received today: this morning, the Bank of Gringotts was robbed. Many experts have labelled this audacious act the crime of the century. Investigation pending. Stay tuned for the updates! Our reporters keep their ear to the ground.";
            string art11 = "This week, the W8 summit is taking place in London. Eight most powerful wizards of the world discuss global affairs. Check out our live update feed to keep yourself informed!";
            string art12 = "As pandemic expands and traveling restrictions tighten, death eaters move online to keep working on their dark mission to bring back You-Know-Who. Beware, cyber crime is on the rise, the wizard police spokesperson has informed the press during special press conference this morning.";
            string art13 = "The night is dark and full of terrors. In the night of February 25, a group of muggle smugglers arrested on Latvia—Belarus border with 400 l of polyjuice potion. It is the largest illegal polyjuice freight confiscated in recorded history. Investigation pending. Follow us for the latest news!";
            string art14 = "The Wizarding Wireless Network hae published their Top 100 of 2020. Do you want to know who made it? Listen to our special Spotify playlist!";
            string art15 = "In this exclusive interview, Blodwyn Bludd talks his music, as well as opens up about the struggles of a vampire and his love story with a werewolf.";
            string art16 = "Great news for all the vegan wizards and witches out there! Qizilbash Quality Confectionary announces new vegan product line. ";
            string art17 = "Great news for all the witches and wizards in Riga: Madam Malkin's Robes for All Occasions will open a showroom here just in a couple of months. At the moment, opening is planned for early May. The showroom will be located on Miera Street: Madam Malkin thinks — quite rightfully — it will blend in perfectly, as well as will definitely seize the opportuity to capitalize on the account of muggle hipsters of the area.";
            string art18 = "It's official: Royal Star Steam Co. goes public";
            string art19 = "Hogwarts Railways expands to France";
            string art20 = "";
            string art21 = "";
            string art22 = "";
            string art23 = "";
            string art24 = "";
            string art25 = "";
            string art26 = "";
            string art27 = "";
            string art28 = "";
            string art29 = "";
            string art30 = "";
            string art31 = "";
            string art32 = "";
            string art33 = "";
            string art34 = "";
            string art35 = "";
            string art36 = "";

            News = new List<Article>
            {
                new Article(1, (int)TopicName.Latvia, "Riga has good chances to host Quidditch World Cup 2025", "Ludo Bagman", art01, 2021, 1, 13, 13, 15, 3),
                new Article(2, (int)TopicName.Latvia, "Latvia in Top 5 of best countries for wizard start-ups", "Betty Braithwaite", art02, 2021, 2, 26, 21, 1, 56),
                new Article(3, (int)TopicName.Latvia, "Breaking: Sirius Black spotted in Gulbene", "Barnabas Cuffe", art03, 2021, 2, 27, 11, 46, 1),
                new Article(4, (int)TopicName.Latvia, "The Singing Sorceress' concert in Sigulda cancelled", "Winkus Oddpick", art04, 2021, 1, 29, 22, 37, 28),
                new Article(5, (int)TopicName.Latvia, "British Minister of Magic visits Riga", "Winkus Oddpick", art05, 2021, 1, 25, 7, 49, 0),
                new Article(6, (int)TopicName.Latvia, "Five quidditch players arrested in Daugavpils for breaking lockdown rules", "Betty Braithwaite", art06, 2021, 2, 2, 18, 0, 0),
                new Article(7, (int)TopicName.Business, "Lean year for mandrake growers, prices have skyrocketed", "Barnabas Cuffe", art07, 2021, 2, 19, 10, 9, 25),
                new Article(8, (int)TopicName.Culture, "Hobbies during pandemic: How to create a horcrux at home", "Tom Marvolo Riddle", art08, 2021, 2, 27, 23, 15, 3),
                new Article(9, (int)TopicName.Sport, "The Triwizard Tournament 2021 to take place fully online", "Ludo Bagman", art09, 2021, 2, 27, 23, 7, 59),
                new Article(10, (int)TopicName.World, "Crime of the century? Gringotts robbed", "Zamira Gulch", art10, 2021, 2, 13, 8, 23, 23),
                new Article(11, (int)TopicName.World, "Latest news from the W8 summit: The most powerful wizards meet in London", "Zamira Gulch", art11, 2021, 1, 31, 20, 1, 38),
                new Article(12, (int)TopicName.Crime, "Death eaters go online: Cyber crime is rising during pandemic", "Dempster Wiggleswade", art12, 2021, 2, 27, 23, 35, 47),
                new Article(13, (int)TopicName.Crime, "400 l of polyjuice potion confiscated on Belarus–Latvia border", "Dempster Wiggleswade", art13, 2021, 2, 25, 10, 14, 21),
                new Article(14, (int)TopicName.Culture, "The Wizarding Wireless Network Top 100 of 2020", "Rita Skeeter", art14, 2020, 12, 31, 16, 11, 33),
                new Article(15, (int)TopicName.Culture, "The Vampire from the Valleys: Interview with Blodwyn Bludd", "Zamira Gulch", art15, 2021, 1, 28, 12, 0, 39),
                new Article(16, (int)TopicName.Business, "Qizilbash Quality Confectionary announces new vegan product line", "Zamira Gulch", art16, 2021, 2, 1, 6, 0, 1),
                new Article(17, (int)TopicName.Business, "Madam Malkin's Robes for All Occasions to open a showroom in Riga", "Zamira Gulch", art17, 2021, 2, 7, 9, 5, 0),
                new Article(18, (int)TopicName.Business, "It's official: Royal Star Steam Co. goes public", "Zamira Gulch", art18, 2021, 1, 30, 11, 11, 11),
                new Article(19, (int)TopicName.Business, "Hogwarts Railways expands to France", "Zamira Gulch", art19, 2021, 2, 10, 10, 0, 17),
                new Article(20, (int)TopicName.Business, "The Vampire from the Valleys: Interview with Blodwyn Bludd", "Barnabas Cuffe", art20, 2021, 2, 12, 9, 23, 6),
                new Article(21, (int)TopicName.Culture, "Hogwarts presents free online learning platform", "Rita Skeeter", art21, 2021, 2, 24, 15, 15, 0),
                new Article(22, (int)TopicName.Culture, "Heads over heels: Nearly Headless Nick on finding his true love", "Rita Skeeter", art22, 2021, 2, 16, 11, 19, 31),
                new Article(23, (int)TopicName.Culture, "Do muggles rock? Exploring muggle music", "Rita Skeeter", art23, 2021, 2, 19, 7, 57, 51),
                new Article(24, (int)TopicName.Sport, "Dungeons and Dragons: Lame muggle game redefined", "Ludo Bagman", art24, 2021, 2, 14, 14, 10, 1),
                new Article(25, (int)TopicName.Sport, "Exclusive: Viktor Krum revisits historical Bulgaria victory", "Ludo Bagman", art25, 2021, 2, 21, 17, 17, 40),
                new Article(26, (int)TopicName.Sport, "Good news for quidditch players: New Nimbus 2021 finally out!", "Ludo Bagman", art26, 2021, 2, 3, 9, 42, 15),
                new Article(27, (int)TopicName.Sport, "First ever Wizard Chess World Championship to take place in 2022", "Ludo Bagman", art27, 2021, 2, 25, 13, 14, 13),
                new Article(28, (int)TopicName.Sport, "Five experts, five broomsticks. Which one an aspiring quidditch world champion should go for?", "Ludo Bagman", art28, 2021, 2, 23, 12, 1, 1),
                new Article(29, (int)TopicName.World, "Harry Potter tops The Wizards Magazine 20 Under 20 2020 List", "Barnabas Cuffe", art29, 2021, 2, 11, 12, 19, 2),
                new Article(30, (int)TopicName.World, "Breaking: The Dark Lord is here!", "Barnabas Cuffe", art30, 2021, 2, 13, 6, 6, 6),
                new Article(31, (int)TopicName.World, "The Slytheryn Heir to start school at Hogwarts this autumn", "Zamira Gulch", art31, 2021, 1, 27, 10, 0, 19),
                new Article(32, (int)TopicName.World, "Longing for travel: Top 10 destinations for a short flying Ford Anglia trip", "Zamira Gulch", art32, 2021, 2, 4, 6, 8, 10),
                new Article(33, (int)TopicName.Crime, "Lucius Malfoy wanted for an illegal hairdresser visit", "Dempster Wiggleswade", art33, 2021, 2, 15, 20, 2, 16),
                new Article(34, (int)TopicName.Crime, "Beware: Fake Deathly Hallows replicas have swarmed the market", "Dempster Wiggleswade", art34, 2021, 2, 20, 19, 37, 30),
                new Article(35, (int)TopicName.Crime, "You-Know-Who thought to be behind The Wizard Bulletin fake news portal", "Zamira Gulch", art35, 2021, 2, 18, 11, 5, 11),
                new Article(36, (int)TopicName.Crime, "Telegram refuses to ban Death Eaters' channels", "Dempster Wiggleswade", art36, 2021, 2, 28, 12, 00, 39),
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
