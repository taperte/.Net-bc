using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaLogic.DB;

namespace CinemaWeb.Models
{
    public class MovieSeatsViewModel
    {
        public Movies Movie { get; set; }
        public List<DateTime> Screenings { get; set; }
        public List<Seats> Seats { get; set; }
        public List<Genres> Genres { get; set; }
        public List<decimal> Prices { get; set; }

        public MovieSeatsViewModel()
        {
            Screenings = new List<DateTime>();
            Seats = new List<Seats>();
            Genres = new List<Genres>();
            Prices = new List<decimal>();
        }
    }
}
