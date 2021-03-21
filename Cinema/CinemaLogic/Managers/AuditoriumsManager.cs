using System;
using System.Collections.Generic;
using System.Text;
using CinemaLogic.DB;
using System.Linq;

namespace CinemaLogic.Managers
{
    public class AuditoriumsManager
    {
        //Returns a list of seats of all types in a certain auditorium.
        public List<AuditoriumSeats> AuditoriumSeats(int id)
        {
            using (var db = new CinemaDB())
            {
                var seats = db.AuditoriumSeats.Where(s => s.AuditoriumId == id).ToList();
                foreach (var s in seats)
                {
                    s.Auditorium = db.Auditoriums.FirstOrDefault(a => a.Id == s.AuditoriumId);
                    s.Seat = db.Seats.FirstOrDefault(seat => seat.Id == s.SeatId);
                }
                return seats;
            }
        }

        //Calculates total capacity for a certain auditorium.
        public int AuditoriumCapacity(int id)
        {
            using (var db = new CinemaDB())
            {
                var capacity = 0;
                var seats = db.AuditoriumSeats.Where(s => s.AuditoriumId == id).ToList();
                foreach (var s in seats)
                {
                    capacity += s.SeatCount;
                }
                return capacity;
            }
        }

        //Returns a list of all auditoriums.
        public List<Auditoriums> GetAuditoriums()
        {
            using (var db = new CinemaDB())
            {
                return db.Auditoriums.OrderBy(a => a.Id).ToList();
            }
        }

        //Returns an auditorium by ID.
        public Auditoriums GetAuditorium(int id)
        {
            using (var db = new CinemaDB())
            {
                return db.Auditoriums.FirstOrDefault(a => a.Id == id);
            }
        }
    }
}
