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
        public List<Genres> Genres { get; set; }
        public List<AuditoriumSeats> AuditoriumSeats { get; set; }
        public List<decimal> Prices { get; set; }

        [Required]
        public int SeatId { get; set; }
        [Required]
        public int TicketCount { get; set; }


        public MovieViewModel()
        {
            Genres = new List<Genres>();
            AuditoriumSeats = new List<AuditoriumSeats>();
            Prices = new List<decimal>();
        }
    }
}
