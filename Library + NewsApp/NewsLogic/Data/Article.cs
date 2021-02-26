using System;
using System.Collections.Generic;
using System.Text;

namespace NewsLogic.Data
{
    public enum Topic 
    { 
        Latvijā,
        Ārvalstīs,
        Kultūra,
        Kriminālziņas,
        Sports,
        Auto
    }
    public class Article
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Body { get; set; }
        public Topic Topic { get; set; }
    }
}
