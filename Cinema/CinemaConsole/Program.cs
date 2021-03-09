using System;
using CinemaLogic.Managers;

namespace CinemaConsole
{
    class Program
    {
        private static GenresManager genres = new GenresManager();
        static void Main(string[] args)
        {
            foreach (var g in genres.GetGenres())
            {
                Console.WriteLine(g.Genre);
            }
        }
    }
}
