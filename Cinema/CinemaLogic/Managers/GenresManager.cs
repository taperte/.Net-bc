using System;
using System.Collections.Generic;
using System.Text;
using CinemaLogic.DB;
using System.Linq;

namespace CinemaLogic.Managers
{
    public class GenresManager
    {
        private MoviesManager manager = new MoviesManager();

        //Returns a list of all genres ordered by name.
        public List<Genres> GetAllGenres()
        {
            using var db = new CinemaDB();
            var genres = db.Genres.OrderBy(g => g.Genre).ToList();
            foreach (var g in genres)
            {
                g.MovieGenres = db.MovieGenres.Where(mg => mg.GenreId == g.Id).OrderBy(mg => mg.Movie.Title).ToList();
                foreach (var mg in g.MovieGenres)
                {
                    mg.Movie = db.Movies.FirstOrDefault(m => m.Id == mg.MovieId);
                    manager.MovieProperties(mg.Movie);
                }
            }
            return genres;
        }


        //Returns a genre with a certain ID.
        public Genres GetGenre(int genreId)
        {
            using var db = new CinemaDB();
            var genre = db.Genres.FirstOrDefault(g => g.Id == genreId);
            genre.MovieGenres = db.MovieGenres.Where(mg => mg.GenreId == genre.Id).OrderBy(mg => mg.Movie.Title).ToList();
            foreach (var mg in genre.MovieGenres)
            {
                mg.Movie = db.Movies.FirstOrDefault(m => m.Id == mg.MovieId);
                manager.MovieProperties(mg.Movie);
            }
            return genre;
        }
    }
}
