﻿using Microsoft.AspNetCore.Mvc;
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
        private static GenresManager genres = new GenresManager();
        private static SeatsManager seats = new SeatsManager();
        private static ScreeningsManager screenings = new ScreeningsManager();
        private static AuditoriumsManager auditoriums = new AuditoriumsManager();

        public IActionResult Index()
        {
            var allMovies = movies.GetAllMovies();
            return View(allMovies);
        }

        public IActionResult MoviesByGenre(int genreId)
        {
            var model = new GenreMovieViewModel
            {
                Genres = genres.GetAllGenres(),
                Movies = movies.GetMoviesByGenre(genreId),
                Genre = genres.GetGenre(genreId)
            };
            return View(model);
        }

        public IActionResult Genres()
        {
            var allGenres = genres.GetAllGenres();
            return View(allGenres);
        }

        public IActionResult Movie(int id)
        {
            var model = new MovieSeatsViewModel
            {
                Seats = seats.GetSeats(),
                Genres = genres.GetAllGenres(),
                Screenings = screenings.Screenings(id),
                Prices = seats.GetSeatPrices(id),
                ScreeningsSeatCount = screenings.SeatCountAllMovieScreenings(id),
            };
            model.Movie = movies.GetMovie(id);
            model.AuditoriumSeatCount = auditoriums.AuditoriumSeatCount((int)model.Movie.AuditoriumId);
            return View(model);
        }
    }
}
