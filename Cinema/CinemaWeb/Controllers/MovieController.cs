using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaLogic.Managers;
using CinemaWeb.Models;

namespace CinemaWeb.Controllers
{
    public class MovieController : Controller
    {
        public static MoviesManager movies = new MoviesManager();
        public static GenresManager genres = new GenresManager();

        public IActionResult Index()
        {
            var allmovies = movies.GetAllMovies();
            return View(allmovies);
        }

        public IActionResult Genres(int genreId)
        {
            var allgenres = genres.GetGenres();
            var bygenre = movies.GetMoviesByGenre(genreId);
            var genresMovies = new GenreMovieViewModel()
            {
                Genres = allgenres,
                Movies = bygenre
            };
            return View(genresMovies);
        }
    }
}
