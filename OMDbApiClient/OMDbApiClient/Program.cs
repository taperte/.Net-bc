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
                string title = Console.ReadLine();
                if (title.ToLower() == "stop")
                {
                    break;
                }
                title = RemoveSpaces(title);
                Console.WriteLine(title);

                //1. Display movie info.
                Console.WriteLine("Movie info:");
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
            Console.Read();
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
            return title.ToLower();
        }
    }
}
