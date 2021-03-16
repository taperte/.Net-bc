using NewsLogic.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAppWeb.Models
{
    public class TopicViewModel
    {
        [Required]
        [Display(Name = "topic title")]
        public string Title { get; set; }

        [Display(Name = "topic description")]
        public string Description { get; set; }

        //under which topic this one should be created
        [Display(Name = "parent topic")]
        public int? ParentTopicId { get; set; }

        public List<Topics> Topics { get; set; }

        //public TopicViewModel()
        //{
        //    Topics = new List<Topics>();
        //}
    }
}
