using Microsoft.AspNetCore.Mvc;
using Library.Logic.Logic;
using Library.Logic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Controllers
{
    public class BookController : Controller
    {
        public static BookManager librarian = new BookManager();

        public IActionResult Index()
        {

            List<Book> books = librarian.GetAvailableBooks();
            return View(books);
        }

        public IActionResult MyBooks()
        {
            List<Book> books = librarian.GetUserBooks();
            return View(books);
        }

        //TakeBook(string title) - gives the book to the user
        public IActionResult TakeBook(string title)
        {
            librarian.TakeBook(title);
            //send back to library catalogue
            return RedirectToAction(nameof(Index));
        }

        //ReturnBook(string title) - returns the book back to the library
        public IActionResult ReturnBook(string title)
        {
            librarian.ReturnBook(title);
            //send back to My Books
            return RedirectToAction(nameof(MyBooks));
        }
    }
}
