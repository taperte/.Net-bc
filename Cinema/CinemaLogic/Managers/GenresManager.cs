using System;
using System.Collections.Generic;
using System.Text;
using CinemaLogic.DB;
using System.Linq;

namespace CinemaLogic.Managers
{
    public class GenresManager
    {
        //Returns a list of all genres ordered by name.
        public List<Genres> GetGenres()
        {
            using CinemaDB db = new CinemaDB();
            return db.Genres.OrderBy(g => g.Genre).ToList();
        }
    }
}
