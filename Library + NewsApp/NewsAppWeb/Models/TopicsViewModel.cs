using NewsLogic.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAppWeb.Models
{
    public class TopicsViewModel
    {
        public List<Topics> Topics { get; set; }
        public Topics Topic { get; set; }

        public TopicsViewModel()
        {
            Topics = new List<Topics>();
        }
    }
}
