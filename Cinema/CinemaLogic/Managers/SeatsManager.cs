using System;
using System.Collections.Generic;
using System.Text;
using CinemaLogic.DB;
using System.Linq;

namespace CinemaLogic.Managers
{
    public class SeatsManager
    {
        public List<Seats> GetSeats()
        {
            using CinemaDB db = new CinemaDB();
            return db.Seats.OrderBy(s => s.Id).ToList();
        }

        //Returns a price list of all seat types for a particular movie.
        public List<decimal> GetSeatPrices(int movieid)
        {
            var prices = new List<decimal>();
            using CinemaDB db = new CinemaDB();
            var movie = db.Movies.FirstOrDefault(m => m.Id == movieid);
            foreach (var seat in db.Seats)
            {
                prices.Add(Math.Round(seat.Coefficient * (decimal)movie.Price, 2, MidpointRounding.AwayFromZero));
            }
            return prices;
        }
    }
}
