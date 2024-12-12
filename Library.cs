using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsConcepts
{
   public class Library : IBorrowable
    {
        private List<Book> booklist = new List<Book>();

        internal void AddBook(Book book)
        {
            booklist.Add(book);
            Console.WriteLine($"Book{book.Title} added to the  library");

        }
        public void DisplayBooks()
        {
            if (booklist.Count == 0)
            {
                Console.WriteLine("no books in library");
            }
            else
            {
                foreach (var book in booklist)
                {
                    book.DisplayInfo();
                }

            }

        }

        public void Borrow()
        {
            Console.WriteLine( "book borrowed");
        }
        public void Return()
        {
            Console.WriteLine("book returned");
        }
    }
}
