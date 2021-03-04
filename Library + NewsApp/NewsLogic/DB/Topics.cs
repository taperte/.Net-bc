using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace NewsLogic.DB
{
    public partial class Topics
    {
        public Topics()
        {
            Articles = new HashSet<Articles>();
        }

        public int TopicId { get; set; }
        public string TopicName { get; set; }

        public virtual ICollection<Articles> Articles { get; set; }
    }
}
