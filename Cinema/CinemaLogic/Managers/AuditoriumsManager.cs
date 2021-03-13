using System;
using System.Collections.Generic;
using System.Text;
using CinemaLogic.DB;
using System.Linq;

namespace CinemaLogic.Managers
{
    class AuditoriumsManager
    {
        public List<Auditoriums> GetAuditoriums()
        {
            //Returns a list of all auditoriums.
            using (var db = new CinemaDB())
            {
                return db.Auditoriums.OrderBy(a => a.Id).ToList();
            }
        }

        //Returns an auditorium by ID.
        public Auditoriums GetAuditorium( int id)
        {
            using (var db = new CinemaDB())
            {
                return db.Auditoriums.FirstOrDefault(a => a.Id == id);
            }
        }
    }
}
