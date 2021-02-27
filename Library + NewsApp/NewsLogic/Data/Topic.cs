using System;
using System.Collections.Generic;
using System.Text;

namespace NewsLogic.Data
{
    public enum TopicName
    {
        Latvia,
        World,
        Culture,
        Business,
        Crime,
        Sport
    }

    public class Topic
    {
        public int Id { get; set; }
        public TopicName Name { get; set; }
    }
}
