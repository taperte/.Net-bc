using System;
using System.Collections.Generic;
using System.Text;
using CinemaLogic.DB;
using System.Linq;

namespace CinemaLogic.Managers
{
    public class ScreeningsManager
    {
        //Returns a list of screenings for a particular movie.
        public List<Screenings> Screenings(int movieId)
        {
            using (var db = new CinemaDB())
            {
                var screenings = db.Screenings.Where(s => s.MovieId == movieId && s.TotalCapacity > 0).ToList();
                foreach (var s in screenings)
                {
                    s.Movie = db.Movies.FirstOrDefault(m => m.Id == s.MovieId);
                }
                return screenings;
            }
        }

        //Returns a list of available seats of all types for a certain screening.
        public List<int> SeatCount(int screeningId)
        {
            var seats = new List<int>();
            using (var db = new CinemaDB())
            {
                var screening = GetScreening(screeningId);
                seats.Add((int)screening.BasicSeats);
                seats.Add((int)screening.Sofa);
                seats.Add((int)screening.Balcony);
            }
            return seats;
        }

        //Gets a list of screenings for a particular movie.
        //For each screening, saves available seats of each type to a list;
        //saves all sets of seat counts to a list.
        public List<List<int>> SeatCountAllMovieScreenings(int movieId)
        {
            List<List<int>> seats = new List<List<int>>();
            using (var db = new CinemaDB())
            {
                var screenings = Screenings(movieId);
                foreach (var s in screenings)
                {
                    var seatsOneScreening = SeatCount(s.Id);
                    seats.Add(seatsOneScreening);
                }
            }
            return seats;
        }

        //Returns a screening by ID.
        public Screenings GetScreening(int id)
        {
            using (var db = new CinemaDB())
            {
                var screening = db.Screenings.FirstOrDefault(s => s.Id == id);
                screening.Movie = db.Movies.FirstOrDefault(m => m.Id == screening.MovieId);
                screening.Movie.Auditorium = db.Auditoriums.FirstOrDefault(a => a.Id == screening.Movie.AuditoriumId);
                return screening;
            }
        }

        //Returns a list of all screenings.
        public List<Screenings> GetAllScreenings()
        {
            using (var db = new CinemaDB())
            {
                var screenings = db.Screenings.ToList();
                foreach (var s in screenings)
                {
                    s.Movie = db.Movies.FirstOrDefault(m => m.Id == s.MovieId);
                    s.Movie.Auditorium = db.Auditoriums.FirstOrDefault(a => a.Id == s.Movie.AuditoriumId);
                }
                return screenings;
            }
        }
    }
}
