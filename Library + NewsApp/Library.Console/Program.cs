using Library.Logic.Logic;
using Library.Logic.Data;
using System.Collections.Generic;
using System;

namespace LibraryConsole
{
    class Program
    {
        static BookManager librarian = new BookManager();
        static void Main(string[] args)
        {
            List<Book> books = librarian.GetAvailableBooks();
            if (books.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Available books:");
                Console.ResetColor();
                librarian.PrintBookList(books);
                Console.WriteLine();
                while (true)
                {
                    Console.WriteLine("Please enter book title. To quit, enter \"stop\".");
                    string input = Console.ReadLine();
                    if (input.ToLower() == "stop")
                    {
                        break;
                    }
                    else if (input == "")
                    {
                        Console.Write("Invalid input! ");
                        continue;
                    }
                    Book booktaken = librarian.TakeBook(input);
                    if (booktaken == null)
                    {
                        Console.Write("No matches! ");
                    }
                    else
                    {
                        Console.WriteLine($"{booktaken.Title} by {booktaken.Author} was added to your list.");
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Sorry, there are no available books in the catalogue.");
            }
            Console.WriteLine();
            List<Book> userbooks = librarian.GetUserBooks();
            if (userbooks.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Your books:");
                Console.ResetColor();
                librarian.PrintBookList(userbooks);
                Console.WriteLine();
                while (librarian.GetUserBooks().Count > 0)
                {
                    Console.WriteLine("Please enter the title you want to return.\nTo quit, enter \"stop\".");
                    string input = Console.ReadLine();
                    Console.WriteLine();
                    if (input.ToLower() == "stop")
                    {
                        break;
                    }
                    else if (input == "")
                    {
                        Console.Write("Invalid input! ");
                        continue;
                    }
                    Book booktoreturn = librarian.ReturnBook(input);
                    if (booktoreturn == null)
                    {
                        Console.Write("No matches! ");
                    }
                    else
                    {
                        Console.WriteLine($"{booktoreturn.Title} by {booktoreturn.Author} was returned to the library.");
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Your list of books is empty.");
            }
        }
    }
}
