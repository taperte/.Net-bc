using System;
using System.Collections.Generic;

namespace Library.Logic.Data
{
    public class LibraryBooks
    {
        public List<Book> Books { get; set; }

        public LibraryBooks()
        {
            Books = new List<Book>()
            {
                new Book("Harry Potter and the Philosopher's Stone", "J. K. Rowling", 1997, 8),
                new Book("Harry Potter and the Chamber of Secrets", "J. K. Rowling", 1998, 3),
                new Book("Harry Potter and the Prisoner of Azkaban", "J. K. Rowling", 1999, 24),
                new Book("Harry Potter and the Goblet of Fire", "J. K. Rowling", 2000),
                new Book("Harry Potter and the Order of the Phoenix", "J. K. Rowling", 2003, 9),
                new Book("Harry Potter and the Half-Blood Prince", "J. K. Rowling", 2005, 18),
                new Book("Harry Potter and the Deathly Hallows", "J. K. Rowling", 2007, 10),
                new Book("The Sound Pattern of Russian", "Morris Halle", 1958, 15),
                new Book("Syntactic Structures", "Noam Chomsky", 1959, 5),
                new Book("Elements of Acoustic Phonetics", "Peter Ladefoged", 2003),
                new Book("A Course in Phonetics", "Peter Ladefoged", 1995),
                new Book("Phonetic Data Analysis: An Introduction to Instrumental Phonetic Fieldwork", "Peter Ladefoged", 2004, 2),
                new Book("Shrinking Violets: A Field Guide to Shyness", "Joe Moran", 2014),
                new Book("Frankenstein; or, The Modern Prometheus", "Mary Shelly", 1818, 11),
                new Book("Born a Crime", "Trevor Noah", 2016, 12),
                new Book("Wheels of Change: How the Bicycle Empowered Women", " Sue Macy", 2011),
                new Book("The Language of New Media", "Lev Manovich", 2001, 35),
                new Book("The Neverending Story", "Michael Ende", 1973, 10),
                new Book("Howl's Moving Castle", "Diana Wynne Jones", 1986),
                new Book("The Hobbit, or There and Back Again", "J. R. R. Tolkien", 1937, 17),
                new Book("Pippi Longstocking", "Astrid Lindgren", 1945, 4),
                new Book("Comet in Moominland", "Tove Jansson", 1946, 11),
                new Book("Moominsummer Maddness", "Tove Jansson", 1940, 5),
                new Book("Moominland Midwinter", "Tove Jansson", 1941),
                new Book("Moominvalley in November", "Tove Jansson", 1939),
                new Book("Murder on the Orient Express", "Agatha Christie", 1933, 13),
                new Book("Death on the Nile", "Agatha Christie", 1928, 10),
                new Book("The Murder of Roger Ackroyd", "Agatha Christie", 1929, 9),
                new Book("Mio, My Son", "Astrid Lindgren", 1951, 4),
                new Book("Dune", "Frank Herbert", 1965, 2)
            };
        }

        internal object Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
