using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CinemaLogic.DB
{
    public partial class Screenings
    {
        public Screenings()
        {
            Bookings = new HashSet<Bookings>();
        }

        public int Id { get; set; }
        public DateTime Time { get; set; }
        public int MovieId { get; set; }
        public int? BasicSeats { get; set; }
        public int? Sofa { get; set; }
        public int? Balcony { get; set; }
        public int? TotalCapacity { get; set; }

        public virtual Movies Movie { get; set; }
        public virtual ICollection<Bookings> Bookings { get; set; }
    }
}
