using System;
using System.Collections.Generic;
using System.Net.Http;

namespace OMDbApiClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OMDb API client");
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://www.omdbapi.com/");
            string apiKey = "59167d26";
            while (true)
            {
                Console.Write("Please enter movie title: ");
                string title = Console.ReadLine().ToLower();
                if (title == "stop")
                {
                    break;
                }
                if (title.Contains(" "))
                {
                    title = RemoveSpaces(title);
                }

                //1. Display movie info.
                var res = client.GetAsync($"?apikey={apiKey}&t={title}").Result;
                if (res.IsSuccessStatusCode)
                {
                    Movie movie = res.Content.ReadAsAsync<Movie>().Result;
                    //print movie info
                    Console.WriteLine("Movie info:");
                    Console.WriteLine($"Year: {movie.Year}");
                    Console.WriteLine($"Rated: {movie.Rated}");
                    Console.WriteLine($"Released: {movie.Released}");
                    Console.WriteLine($"Runtime: {movie.Runtime}");
                    Console.WriteLine($"Genre: {movie.Genre}");
                    Console.WriteLine($"Director: {movie.Director}");
                    Console.WriteLine($"Actors: {movie.Actors}");
                    Console.WriteLine($"Plot: {movie.Plot}");
                    Console.WriteLine();
                    Console.WriteLine("Ratings:");
                    foreach (var r in movie.Ratings)
                    {
                        Console.WriteLine($"Sourse: {r.Source}");
                        Console.WriteLine($"Value: {r.Value}");
                    }
                }
                Console.WriteLine();
            }

            while (true)
            {
                //movies search
                Console.Write("Please enter movie title: ");
                string title = Console.ReadLine().ToLower();
                if (title == "stop")
                {
                    break;
                }
                if (title.Contains(" "))
                {
                    title = RemoveSpaces(title);
                }

                //1. Display movie info.
                var res = client.GetAsync($"?apikey={apiKey}&s={title}").Result;
                if (res.IsSuccessStatusCode)
                {
                    Movies movies = res.Content.ReadAsAsync<Movies>().Result;
                    //print movies' info
                    foreach (var m in movies.Search)
                    {
                        Console.WriteLine("Movie info:");
                        Console.WriteLine($"Title: {m.Title}");
                        Console.WriteLine($"Year: {m.Year}");
                        Console.WriteLine($"imdbID: {m.imdbID}");
                        Console.WriteLine($"Type: {m.Type}");
                        Console.WriteLine($"Poster: {m.Poster}");
                        Console.WriteLine();
                    }
                }
            }
        }

        //Replaces spaces with "+".
        private static string RemoveSpaces(string title)
        {
            var letterList = new List<string>();
            for (int i = 0; i < title.Length; i++)
            {
                if (title.Substring(i, 1) == " ")
                {
                    letterList.Add("+");
                }
                else
                {
                    letterList.Add(title.Substring(i, 1));
                }
            }
            title = "";
            foreach (var l in letterList)
            {
                title += l;
            }
            return title;
        }
    }
}
