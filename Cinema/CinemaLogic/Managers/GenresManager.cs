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
            var genres = db.Genres.OrderBy(g => g.Genre).ToList();
            foreach (var g in genres)
            {
                g.Movies = db.Movies.Where(m => m.GenreId == g.Id).ToList();
            }
            return genres;
        }


        //Returns a genre with a certain ID.
        public Genres GetGenre(int genreid)
        {
            using CinemaDB db = new CinemaDB();
            var genre = db.Genres.FirstOrDefault(g => g.Id == genreid);
            genre.Movies = db.Movies.Where(m => m.GenreId == genre.Id).ToList();
            return genre;
        }
    }
}
