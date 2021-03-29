using Microsoft.AspNetCore.Http;
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
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }

        public int Id { get; set; }

        [Display(Name = "Image")]
        public IFormFile Image { get; set; }

        public CreateArticleViewModel()
        {
            Topics = new List<Topics>();
        }
    }
}
