using System;
using System.Collections.Generic;
using System.Text;
using CinemaLogic.DB;
using System.Linq;

namespace CinemaLogic.Managers
{
    public class AuditoriumsManager
    {
        //Calculates total capacity for a certain auditorium.
        public int TotalCapacity(Auditoriums auditorium)
        {
            using (var db = new CinemaDB())
            {
                auditorium.TotalCapacity = auditorium.BasicSeats + auditorium.Sofa + auditorium.Balcony;
                db.SaveChanges();
                return (int)auditorium.TotalCapacity;
            }
        }

        //Returns a list of seat count for all seat types
        //in an auditorium.
        public List<int> AuditoriumSeatCount(int id)
        {
            var seats = new List<int>();
            using (var db = new CinemaDB())
            {
                var auditorium = db.Auditoriums.FirstOrDefault(a => a.Id == id);
                seats.Add(auditorium.BasicSeats);
                seats.Add(auditorium.Sofa);
                seats.Add(auditorium.Balcony);
            }
            return seats;
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
