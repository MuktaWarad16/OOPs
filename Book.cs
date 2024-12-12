using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsConcepts
{
    internal class Book : Item, IBorrowable

    {
        public string author { get; set; }
        public string isbn;
        public string ISBN
        {
            get => isbn;
            set => isbn = value;

        }

        public bool IsBorrowed { get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine("Title:{Title},Author:{Author} ISBN:{ISBN}");

        }
        public void Borrow()
        {
            if (IsBorrowed)
            {
                Console.WriteLine("the book is already borrowed");

            }
            else
            {
                IsBorrowed = true;
                Console.WriteLine("the book has been borrowed");

            }
        }

            public void Return()
        {
            if (IsBorrowed)
            {
                Console.WriteLine("the book is already borrowed");

            }
            else
            {
                IsBorrowed = true;
                Console.WriteLine("the book has been returned");

            }
        }
    }
}

