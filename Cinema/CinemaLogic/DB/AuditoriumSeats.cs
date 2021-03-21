using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CinemaLogic.DB
{
    public partial class AuditoriumSeats
    {
        public AuditoriumSeats()
        {
            AvailableSeats = new HashSet<AvailableSeats>();
        }

        public int Id { get; set; }
        public int AuditoriumId { get; set; }
        public int SeatId { get; set; }
        public int SeatCount { get; set; }

        public virtual Auditoriums Auditorium { get; set; }
        public virtual Seats Seat { get; set; }
        public virtual ICollection<AvailableSeats> AvailableSeats { get; set; }
    }
}
