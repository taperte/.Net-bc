using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CinemaLogic.DB
{
    public partial class AvailableSeats
    {
        public AvailableSeats()
        {
            Bookings = new HashSet<Bookings>();
        }

        public int ScreeningId { get; set; }
        public int AuditoriumSeatsId { get; set; }
        public int Id { get; set; }
        public string Type { get; set; }
        public int? Count { get; set; }

        public virtual AuditoriumSeats AuditoriumSeats { get; set; }
        public virtual Screenings Screening { get; set; }
        public virtual ICollection<Bookings> Bookings { get; set; }
    }
}
