using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CinemaLogic.DB
{
    public partial class Genres
    {
        public Genres()
        {
            MovieGenres = new HashSet<MovieGenres>();
            Movies = new HashSet<Movies>();
        }

        public int Id { get; set; }
        public string Genre { get; set; }

        public virtual ICollection<MovieGenres> MovieGenres { get; set; }
        public virtual ICollection<Movies> Movies { get; set; }
    }
}
