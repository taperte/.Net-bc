using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Logic.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int Copies { get; set; }

        public Book()
        {
            Copies = 1;
        }

        public Book(string t, string a, int y, int c = 1)
        {
            Title = t;
            Author = a;
            Year = y;
            Copies = c;
        }

        public void PrintBookInfo()
        {
            Console.WriteLine($"{Title} by {Author}, {Year}");
        }
    }
}
