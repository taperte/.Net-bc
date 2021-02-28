using System;

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
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                if (value >= 0 && value <= 5)
                {
                    id = value;
                }
                else
                {
                    Console.WriteLine("Invalid topic ID number! Topic ID set to 0.");
                }
            }
        }
        public TopicName Name { get; set; }

        public Topic()
        {

        }

        public Topic( int i, TopicName n)
        {
            Id = i;
            Name = n;
        }
    }
}
