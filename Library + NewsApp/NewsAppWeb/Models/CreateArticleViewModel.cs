using NewsLogic.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAppWeb.Models
{
    public class CreateArticleViewModel
    {
        [Required]
        [Display(Name = "Headline")]
        public string Headline { get; set; }

        //under which topic the article should be created
        [Required]
        [Display(Name = "Topic")]
        public int TopicId { get; set; }

        [Required]
        public List<Topics> Topics { get; set; }

        [Required]
        [Display(Name = "Author")]
        public string Author { get; set; }

        [Required]
        [Display(Name = "Text")]
        public string Text { get; set; }


        [Display(Name = "Link to image")]
        public string Image { get; set; }

        public CreateArticleViewModel()
        {
            Topics = new List<Topics>();
        }
    }
}
