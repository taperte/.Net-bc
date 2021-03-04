using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
//#nullable disable

namespace NewsLogic.DB
{
    public partial class Articles
    {
        public int ArticleId { get; set; }
        public int? TopicId { get; set; }
        public string Headline { get; set; }
        public string Author { get; set; }
        public string Body { get; set; }
        public DateTime? WhenAdded { get; set; }

        public virtual Topics Topic { get; set; }
    }
}
