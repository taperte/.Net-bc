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

        public List<AuditoriumSeats> GetAuditoriumSeats(int auditoriumId)
        {
            using var db = new CinemaDB();
            var audSeats = db.AuditoriumSeats.Where(auds => auds.AuditoriumId == auditoriumId).ToList();
            foreach (var seat in audSeats)
            {
                seat.Seat = db.Seats.FirstOrDefault(s => s.Id == seat.SeatId);
            }
            return audSeats;
        }

        //Fills in max seat count during a screening (AvailableSeats table) based on auditorium capacity.
        public void FillInSeatCount()
        {
            using (var db = new CinemaDB())
            {
                var availableSeats = db.AvailableSeats.ToList();
                foreach (var avs in availableSeats)
                {
                    avs.AuditoriumSeats = db.AuditoriumSeats.FirstOrDefault(auds => auds.Id == avs.AuditoriumSeatsId);
                    avs.Count = avs.AuditoriumSeats.SeatCount;
                }
                db.SaveChanges();
            }
        }

        //Fills in the seat type column in the AvailableSeats table. 
        public void FillInSeatTypes()
        {
            using (var db = new CinemaDB())
            {
                var availableSeats = db.AvailableSeats.ToList();
                foreach (var avs in availableSeats)
                {
                    avs.AuditoriumSeats = db.AuditoriumSeats.FirstOrDefault(auds => auds.Id == avs.AuditoriumSeatsId);
                    avs.AuditoriumSeats.Seat = db.Seats.FirstOrDefault(s => s.Id == avs.AuditoriumSeats.SeatId);
                    avs.Type = avs.AuditoriumSeats.Seat.Type;
                }
                db.SaveChanges();
            }
        }
    }
}
