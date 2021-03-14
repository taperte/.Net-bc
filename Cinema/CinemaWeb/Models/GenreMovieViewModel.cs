using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaLogic.DB;

namespace CinemaWeb.Models
{
    public class GenreMovieViewModel
    {
        public List<Genres> Genres { get; set; }
        public List<Movies> Movies { get; set; }
        public Genres Genre { get; set; }

        public GenreMovieViewModel()
        {
            Genres = new List<Genres>();
        }
    }
}
