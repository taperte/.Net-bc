using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CinemaLogic.DB
{
    public partial class Seats
    {
        public Seats()
        {
            Bookings = new HashSet<Bookings>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public decimal Coefficient { get; set; }

        public virtual ICollection<Bookings> Bookings { get; set; }
    }
}
