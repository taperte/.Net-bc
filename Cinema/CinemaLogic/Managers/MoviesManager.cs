using System;
using System.Collections.Generic;
using System.Text;
using CinemaLogic.DB;
using System.Linq;

namespace CinemaLogic.Managers
{
    public class MoviesManager
    {
        //Basic requirements: A web application where the user can browse movies(in different
        //categories) and make a booking for a movie at a specific time.The user must be able to see
        //created bookings and cancel any of them.
        //Categories, movie information (including available times) and bookings are stored in a SQL
        //database.

        //Returns a list of all movies ordered by title.
        public List<Movies> GetAllMovies()
        {
            using CinemaDB db = new CinemaDB();
            List<Movies> movies = db.Movies.OrderBy(m => m.Title).ToList();

            //Assigns value to the genre property for every item in the list.
            foreach (var m in movies)
            {
                m.Genre = db.Genres.FirstOrDefault(g => g.Id == m.GenreId);
            }
            return movies;
        }

        //Returns a list of movies of a certain genre ordered by title; parameter: genre ID.
        public List<Movies> GetMoviesByGenre(int genreId)
        {
            using CinemaDB db = new CinemaDB();
            List<Movies> movies = db.Movies.Where(m => m.GenreId == genreId).
                                            OrderBy(m => m.Title).ToList();

            //Assigns value to the genre property for every item in the list.
            foreach (var m in movies)
            {
                m.Genre = db.Genres.FirstOrDefault(g => g.Id == m.GenreId);
            }
            return movies;
        }



    }
}
