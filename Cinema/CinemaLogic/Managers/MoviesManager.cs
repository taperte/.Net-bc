using System;
using System.Collections.Generic;
using System.Text;
using CinemaLogic.DB;
using System.Linq;

namespace CinemaLogic.Managers
{
    public class MoviesManager
    {
        //Returns a list of all movies ordered by title.
        public List<Movies> GetAllMovies()
        {
            using (CinemaDB db = new CinemaDB())
            {
                List<Movies> movies = db.Movies.OrderBy(m => m.Title).ToList();

                //Fills virtual properties for every movie in the list.
                foreach (var m in movies)
                {
                    MovieProperties(m);
                }
                return movies;
            }
        }

        //Returns a movie by ID.
        public Movies GetMovie(int id)
        {
            using CinemaDB db = new CinemaDB();
            var movie = db.Movies.FirstOrDefault(m => m.Id == id);
            MovieProperties(movie);
            return movie;
        }

        //Returns a list of movies of a certain genre ordered by title; parameter: genre ID.
        public List<Movies> GetMoviesByGenre(int genreId)
        {
            using CinemaDB db = new CinemaDB();
            List<Movies> movies = db.Movies.Where(m => m.GenreId == genreId).
                                            OrderBy(m => m.Title).ToList();

            //Fills virtual properties for every item in the list.
            foreach (var m in movies)
            {
                MovieProperties(m);
            }
            return movies;
        }

        //Fills in virtual properties for a movie.
        public void MovieProperties(Movies movie)
        {
            using (var db = new CinemaDB())
            {
                //genre info
                movie.Genre = db.Genres.FirstOrDefault(g => g.Id == movie.GenreId);

                //list of genres
                movie.MovieGenres = db.MovieGenres.Where(mg => mg.MovieId == movie.Id).ToList();
                foreach (var mg in movie.MovieGenres)
                {
                    mg.Genre = db.Genres.FirstOrDefault(g => g.Id == mg.GenreId);
                }
                movie.MovieGenres = movie.MovieGenres.OrderBy(mg => mg.Genre.Genre).ToList();

                //auditorium info
                movie.Auditorium = db.Auditoriums.FirstOrDefault(a => a.Id == movie.AuditoriumId);

                //seat types in the auditorium (to display prices in the movie view)
                movie.Auditorium.AuditoriumSeats = db.AuditoriumSeats
                                                   .Where(audSeats => audSeats.AuditoriumId == movie.Auditorium.Id)
                                                   .ToList();
                //seat info
                foreach (var s in movie.Auditorium.AuditoriumSeats)
                {
                    s.Seat = db.Seats.FirstOrDefault(seat => seat.Id == s.SeatId);
                }
                //list of screenings
                movie.Screenings = db.Screenings.Where(s => s.MovieId == movie.Id).ToList();
                foreach (var s in movie.Screenings)
                {
                    int totalSeats = 0;
                    //available seat list for every screening
                    s.AvailableSeats = db.AvailableSeats.Where(avs => avs.ScreeningId == s.Id && avs.Count > 0).ToList();

                    //for each seat type in AvailableSeats
                    foreach (var avs in s.AvailableSeats)
                    {
                        //counts available seats
                        totalSeats += avs.Count.Value;

                        //screening info
                        avs.Screening = db.Screenings.FirstOrDefault(scr => scr.Id == s.Id);

                        //auditorium and seat type info through the AuditoriumSeats property
                        avs.AuditoriumSeats = db.AuditoriumSeats.FirstOrDefault(audSeat => audSeat.Id == avs.AuditoriumSeatsId);
                        avs.AuditoriumSeats.Auditorium = db.Auditoriums.FirstOrDefault(a => a.Id == avs.AuditoriumSeats.AuditoriumId);
                        avs.AuditoriumSeats.Seat = db.Seats.FirstOrDefault(seat => seat.Id == avs.AuditoriumSeats.SeatId);
                    }
                    //sets totla seat count
                    s.TotalSeatCount = totalSeats;
                }
                db.SaveChanges();
            }
        }
    }
}
