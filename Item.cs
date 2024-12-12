using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsConcepts
{
    abstract class Item
    {
        public string Title { get; set; }

        public abstract void DisplayInfo();
    }
}
