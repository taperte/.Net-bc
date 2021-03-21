using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CinemaLogic.DB
{
    public partial class Movies
    {
        public Movies()
        {
            MovieGenres = new HashSet<MovieGenres>();
            Screenings = new HashSet<Screenings>();
        }

        public int Id { get; set; }
        public int? GenreId { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public int Duration { get; set; }
        public decimal? Price { get; set; }
        public string Country { get; set; }
        public string Abstract { get; set; }
        public string Trailer { get; set; }
        public string Poster { get; set; }
        public string OriginalTitle { get; set; }
        public int? AuditoriumId { get; set; }

        public virtual Auditoriums Auditorium { get; set; }
        public virtual Genres Genre { get; set; }
        public virtual ICollection<MovieGenres> MovieGenres { get; set; }
        public virtual ICollection<Screenings> Screenings { get; set; }
    }
}
