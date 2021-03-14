using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CinemaLogic.DB
{
    public partial class Auditoriums
    {
        public Auditoriums()
        {
            Movies = new HashSet<Movies>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int BasicSeats { get; set; }
        public int Sofa { get; set; }
        public int Balcony { get; set; }
        public int? TotalCapacity { get; set; }

        public virtual ICollection<Movies> Movies { get; set; }
    }
}
