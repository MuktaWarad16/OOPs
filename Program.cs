using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Text;

namespace OOPsConcepts
{
    internal class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to library");
            Library library = new Library();
            Book book1 = new Book { Title="drama",  ISBN = "1091" };
            Book book2 = new Book { Title ="comedy",  ISBN = "5432" };
            Book book3 = new Book { Title = "romance", ISBN = "0765" };

            library.AddBook(book1);
            library.AddBook(book2); 
            library.AddBook(book3);

            Console.WriteLine(  "\ndisplaying library books");
            library.DisplayBooks();

            Console.WriteLine("\nBorrow 'drama'");
            book1.Borrow();

            Console.WriteLine("\nBorrow 'drama' again");
            book1.Borrow();

            Console.WriteLine("\nReturning 'drama'");
            book1.Borrow();

            Console.WriteLine("\nDisplaying library books again");
            library.DisplayBooks();

        }
    }
}
