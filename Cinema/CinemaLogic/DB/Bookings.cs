﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CinemaLogic.DB
{
    public partial class Bookings
    {
        public int Id { get; set; }
        public int? TicketCount { get; set; }
        public decimal? TotalPrice { get; set; }
        public int AvailableSeatsId { get; set; }

        public virtual AvailableSeats AvailableSeats { get; set; }
    }
}
