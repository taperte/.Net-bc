using System;
using CinemaLogic.Managers;

namespace CinemaConsole
{
    class Program
    {
        private static GenresManager genres = new GenresManager();
        private static MoviesManager movies = new MoviesManager();
        static void Main(string[] args)
        {
            foreach (var g in genres.GetGenres())
            {
                Console.WriteLine(g.Genre);
            }

            foreach (var m in movies.GetMoviesByGenre(7))
            {
                Console.WriteLine(m.Title);
            }
        }
    }
}
