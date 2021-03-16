using CinemaLogic.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb.Models
{
    public class MyBookingsViewModel
    {
        public List<Bookings> Bookings { get; set; }
        public decimal TotalPrice { get; set; }

        public MyBookingsViewModel()
        {
            Bookings = new List<Bookings>();
        }
    }
}
