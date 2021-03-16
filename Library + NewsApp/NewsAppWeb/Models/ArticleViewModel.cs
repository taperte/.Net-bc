using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsLogic.DB;

namespace NewsAppWeb.Models
{
    public class ArticleViewModel
    {
        public List<Topics> Topics { get; set; }
        public Articles Article { get; set; }

        public ArticleViewModel()
        {
            Topics = new List<Topics>();
        }
    }
}
