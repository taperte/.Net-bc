using System;
using System.Collections.Generic;
using System.Text;

namespace NewsLogic.Data
{
    public enum TopicName
    {
        Latvijā,
        Ārvalstīs,
        Kultūra,
        Kriminālziņas,
        Sports,
        Auto
    }

    public class Topic
    {
        public int Id { get; set; }
        public TopicName Name { get; set; }
    }
}
