using System;
using System.Collections.Generic;
using System.Text;
using CinemaLogic.DB;
using System.Linq;

namespace CinemaLogic.Managers
{
    public class ScreeningsManager
    {
        //Returns a list of screenings for a particular movie where seats are available.
        public List<Screenings> MovieScreenings(int movieId)
        {
            using (var db = new CinemaDB())
            {
                //All screening for a particular movie are added to a list.
                var allScreenings = db.Screenings.Where(s => s.MovieId == movieId).OrderBy(s => s.Time).ToList();

                //For each screening in the list, the AvailableSeats property is filled
                //to count available seats.
                foreach (var s in allScreenings)
                {
                    //Seat info: each screening has a list of seat types.
                    s.AvailableSeats = db.AvailableSeats.Where(avs => avs.ScreeningId == s.Id).ToList();
                    foreach (var avs in s.AvailableSeats)
                    {
                        //Each seat type in the screening has seat count depending on auditorium.
                        avs.AuditoriumSeats = db.AuditoriumSeats.FirstOrDefault(audseat => audseat.Id == avs.AuditoriumSeatsId);
                    }
                }
                //The final list of screenings includes only those that have seats available.
                var availableScreenings = new List<Screenings>();
                int availableSeats = 0;

                //The program calculates total seat count for every screening in the list.
                foreach (var s in allScreenings)
                {
                    foreach (var seats in s.AvailableSeats)
                    {
                        availableSeats += seats.AuditoriumSeats.SeatCount;
                    }
                    //If total seat count is greater than 0,
                    if (availableSeats > 0)
                    {
                        //the screening is added to the final list.
                        availableScreenings.Add(s);
                    }
                    availableSeats = 0;
                }
                //In the final list, the rest of virtual properties are filled.
                foreach (var s in availableScreenings)
                {
                    //Movie info.
                    s.Movie = db.Movies.FirstOrDefault(m => m.Id == s.MovieId);

                    //Auditorium info.
                    s.Movie.Auditorium = db.Auditoriums.FirstOrDefault(a => a.Id == s.Movie.AuditoriumId);

                    foreach (var avs in s.AvailableSeats)
                    {
                        //Seat info.
                        avs.AuditoriumSeats.Seat = db.Seats.FirstOrDefault(seat => seat.Id == avs.AuditoriumSeats.SeatId);

                        //Auditorium info.
                        avs.AuditoriumSeats.Auditorium = db.Auditoriums.FirstOrDefault(a => a.Id == avs.AuditoriumSeats.AuditoriumId);
                    }
                }
                return availableScreenings;
            }
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

        public Screenings GetScreeningBySeatId(int seatId)
        {
            using (var db = new CinemaDB())
            {
                var seat = db.AvailableSeats.FirstOrDefault(avs => avs.Id == seatId);
                return db.Screenings.FirstOrDefault(s => s.Id == seat.ScreeningId);
            }
        }
    }
}
