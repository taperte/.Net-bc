using System;
using System.Collections.Generic;
using System.Text;
using CinemaLogic.DB;
using System.Linq;

namespace CinemaLogic.Managers
{
    public class BookingsManager
    {
        public List<Bookings> GetBookings()
        {
            using CinemaDB db = new CinemaDB();
            return db.Bookings.OrderBy(b => b.BookedTime).ToList();
        }

    }
}
