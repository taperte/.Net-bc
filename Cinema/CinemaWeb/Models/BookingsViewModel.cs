using CinemaLogic.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb.Models
{
    public class BookingsViewModel
    {
        public List<Bookings> Bookings { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
