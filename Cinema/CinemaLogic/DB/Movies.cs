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
            Bookings = new HashSet<Bookings>();
        }

        public int Id { get; set; }
        public int? GenreId { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public DateTime? ScreeningTime1 { get; set; }
        public DateTime? ScreeningTime2 { get; set; }
        public DateTime? ScreeningTime3 { get; set; }
        public DateTime? ScreeningTime4 { get; set; }
        public DateTime? ScreeningTime5 { get; set; }
        public int Duration { get; set; }
        public decimal? Price { get; set; }

        public virtual Genres Genre { get; set; }
        public virtual ICollection<Bookings> Bookings { get; set; }
    }
}
