using Library.Logic.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Logic.Logic
{
    public class BookManager
    {
        public LibraryBooks LibraryBooks { get; set; }
        public UserBooks UserBooks { get; set; }

        public BookManager()
        {
            LibraryBooks = new LibraryBooks();
            UserBooks = new UserBooks();
        }

        //GetAvailableBooks() - returns list of all available books
        public List<Book> GetAvailableBooks()
        {
            return LibraryBooks.Books.Where(b => b.Copies > 0).
                                      OrderBy(b => b.Title).ToList();
        }

        //GetUserBooks() - returns list of user's books
        public List<Book> GetUserBooks()
        {
            return UserBooks.Books.OrderBy(b => b.Title).ToList();
        }

        //TakeBook(string title) - gives the book to the user
        public Book TakeBook(string input)
        {
            Book book = GetAvailableBooks().
                        Find(b => b.Title.ToLower().
                        Contains(input.ToLower()));
            if (book != null && book.Copies > 0)
            {
                book.Copies--;
                UserBooks.Books.Add(book);
            }
            return book;
        }

        //ReturnBook(string title) - returns the book back to the library
        public Book ReturnBook(string input)
        {
            Book book = UserBooks.Books.
                        Find(b => b.Title.ToLower() == input.ToLower());
            //if the book is found,
            if (book != null)
            {
                //it is removed from the reader's list
                UserBooks.Books.Remove(book);
                Book returned = LibraryBooks.Books.Find(b => b.Title == book.Title);
                //if library catalogue does not contain this book,
                if (returned == null)
                {
                    //it is added to the list
                    LibraryBooks.Books.Add(returned);
                }
                else
                {
                    //otherwise the number of existing copies is increased
                    returned.Copies++;
                }
            }
            return book;
        }


        public void PrintBookList(List<Book> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                list[i].PrintBookInfo();
            }
        }
    }
}
