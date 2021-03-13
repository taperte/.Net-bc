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

        //Seat types.Database contains information about seat types - name and price.Before
        //making a reservation, the user can choose seat type. Total price must be based on seat
        //type.

        //Auditoriums.Database contains information about auditoriums, each auditorium has a
        //name and max capacity.Each movie is scheduled to be in a specific auditorium.
        //Information about the auditorium must be displayed when booking a movie.Each
        //booking decreases available seats for a movie (based on auditorium capacity) and the
        //movie is not available if it is fully booked.

        //Returns a list of all movies ordered by title.
        public List<Movies> GetAllMovies()
        {
            using CinemaDB db = new CinemaDB();
            List<Movies> movies = db.Movies.OrderBy(m => m.Title).ToList();

            //Assigns value to the genre and auditorium properties for every item in the list.
            foreach (var m in movies)
            {
                m.Genre = db.Genres.FirstOrDefault(g => g.Id == m.GenreId);
                m.Auditorium = db.Auditoriums.FirstOrDefault(a => a.Id == m.AuditoriumId);
            }
            return movies;
        }

        //Returns a list of screening times of a particular movie.
        public List<DateTime> Screenings(int movieid)
        {
            using CinemaDB db = new CinemaDB();
            var screenings = new List<DateTime>();
            var movie = GetMovie(movieid);
            if (movie.ScreeningTime1 != null)
            {
                screenings.Add((DateTime)movie.ScreeningTime1);
            }
            if (movie.ScreeningTime2 != null)
            {
                screenings.Add((DateTime)movie.ScreeningTime2);
            }
            if (movie.ScreeningTime3 != null)
            {
                screenings.Add((DateTime)movie.ScreeningTime3);
            }
            if (movie.ScreeningTime4 != null)
            {
                screenings.Add((DateTime)movie.ScreeningTime4);
            }
            if (movie.ScreeningTime5 != null)
            {
                screenings.Add((DateTime)movie.ScreeningTime5);
            }
            return screenings;
        }

        //Returns a movie by ID.
        public Movies GetMovie(int id)
        {
            using CinemaDB db = new CinemaDB();
            var movie = db.Movies.FirstOrDefault(m => m.Id == id);
            movie.Genre = db.Genres.FirstOrDefault(g => g.Id == movie.GenreId);
            movie.Auditorium = db.Auditoriums.FirstOrDefault(a => a.Id == movie.AuditoriumId);
            return movie;
        }

        //Returns a list of movies of a certain genre ordered by title; parameter: genre ID.
        public List<Movies> GetMoviesByGenre(int genreId)
        {
            using CinemaDB db = new CinemaDB();
            List<Movies> movies = db.Movies.Where(m => m.GenreId == genreId).
                                            OrderBy(m => m.Title).ToList();

            //Assigns value to the genre and auditorium properties for every item in the list.
            foreach (var m in movies)
            {
                m.Genre = db.Genres.FirstOrDefault(g => g.Id == m.GenreId);
                m.Auditorium = db.Auditoriums.FirstOrDefault(a => a.Id == m.AuditoriumId);
            }
            return movies;
        }
    }
}
