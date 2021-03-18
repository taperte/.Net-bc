using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CinemaLogic.DB;

namespace CinemaWeb.Models
{
    public class MovieViewModel
    {
        public Movies Movie { get; set; }
        public List<Screenings> Screenings { get; set; }

        [Required]
        public int ScreeningId { get; set; }
        public List<Seats> Seats { get; set; }
        public List<Genres> Genres { get; set; }
        public List<decimal> Prices { get; set; }
        public List<List<int>> ScreeningsSeatCount { get; set; }
        public List<int> AuditoriumSeatCount { get; set; }

        [Required]
        public int TicketCount { get; set; }


        public MovieViewModel()
        {
            Screenings = new List<Screenings>();
            Seats = new List<Seats>();
            Genres = new List<Genres>();
            Prices = new List<decimal>();
            ScreeningsSeatCount = new List<List<int>>();
            AuditoriumSeatCount = new List<int>();
        }
    }
}
