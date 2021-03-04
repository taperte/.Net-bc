using Library.Logic._DB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Library.Logic.Logic
{
    public class BookManager
    {
        
        public BookManager()
        {

        }

        //GetAvailableBooks() - returns list of all available books
        public List<Books> GetAvailableBooks()
        {
            var books = new List<Books>();
            using (LibraryDatabase library = new LibraryDatabase())
            {
                books = library.Books.Where(b => b.Copies > 0).
                                      OrderBy(b => b.Title).ToList();
            }
            return books;
        }

        //GetUserBooks() - returns list of user's books
        public List<UserBooks> GetUserBooks()
        {
            var userbooks = new List<UserBooks>();
            using (LibraryDatabase library = new LibraryDatabase())
            {
                userbooks = library.UserBooks.OrderBy(b => b.Title).ToList();
            }
            return userbooks;
        }

        //TakeBook(string title) - gives the book to the user
        public UserBooks TakeBook(string input)
        {
            UserBooks userbook = new UserBooks();
            using (LibraryDatabase library = new LibraryDatabase())
            {
                //library.UserBooks.RemoveRange(library.UserBooks);
                Books book = GetAvailableBooks().
                             FirstOrDefault(b => b.Title.ToLower().
                             Contains(input.ToLower()));
                if (book != null && book.Copies > 0)
                {
                    book.Copies--;
                    userbook.Title = book.Title;
                    userbook.Author = book.Author;
                    userbook.Year = book.Year;
                    library.UserBooks.Add(userbook);
                    library.SaveChanges();
                    return userbook;
                }
                library.SaveChanges();
            }
            return null;
        }

        //ReturnBook(string title) - returns the book back to the library
        public Books ReturnBook(string input)
        {
            Books returned = new Books();
            using (LibraryDatabase library = new LibraryDatabase())
            {
                UserBooks userbook = library.UserBooks.FirstOrDefault(b => b.Title.ToLower() == input.ToLower());
                //if the book is found,
                if (userbook != null)
                {
                    //it is removed from the reader's list
                    library.UserBooks.Remove(userbook);
                    returned = library.Books.FirstOrDefault(b => b.Title == userbook.Title);
                    //if library catalogue does not contain this book,
                    if (returned == null)
                    {
                        //it is added to the list
                        library.Books.Add(returned);
                    }
                    else
                    {
                        //otherwise the number of existing copies is increased
                        returned.Copies++;
                    }
                    library.SaveChanges();
                    return returned;
                }
                library.SaveChanges();
            }
            return null;
        }

        public void PrintBookList(List<Books> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                PrintBookInfo(list[i]);
            }
        }

        public void PrintBookList(List<UserBooks> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                PrintBookInfo(list[i]);
            }
        }

        public void PrintBookInfo(Books book)
        {
            Console.WriteLine($"{book.Title} by {book.Author}, {book.Year}");
        }

        public void PrintBookInfo(UserBooks book)
        {
            Console.WriteLine($"{book.Title} by {book.Author}, {book.Year}");
        }
    }
}
