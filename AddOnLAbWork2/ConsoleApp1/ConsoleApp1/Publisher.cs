using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Publisher
    {
        int Year { get; set; }
        string Town;
        public string Name;
        public SortedSet<string> ISBNBooks;
        public Publisher()
        {
            Year = -1;
            Town = "";
            Name = "";
            ISBNBooks = new SortedSet<string>();
        }

        public Publisher(string name, string NumberOfBook)
        {
            this.Name = name;
            this.Town = "";
            this.Year = -1;
            ISBNBooks = new SortedSet<string>();
            ISBNBooks.Add(NumberOfBook);
        }

        public Publisher(int year, string town, string name)
        {
            this.Year = year;
            this.Town = town;
            this.Name = name;
            ISBNBooks = new SortedSet<string>();
        }
    }
}
