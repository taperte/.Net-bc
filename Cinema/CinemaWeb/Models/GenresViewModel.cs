using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaLogic.DB;

namespace CinemaWeb.Models
{
    public class GenresViewModel
    {
        public List<Genres> Genres { get; set; }
        public Genres Genre { get; set; }

        public GenresViewModel()
        {
            Genres = new List<Genres>();
        }
    }
}
