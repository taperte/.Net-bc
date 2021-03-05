using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsLogic.DB;

namespace NewsAppWeb.Models
{
    public class TopicArticleViewModel
    {
        public List<Topics> Topics { get; set; }
        public List<Articles> Articles { get; set; }
        public Articles Article { get; set; }
    }
}
