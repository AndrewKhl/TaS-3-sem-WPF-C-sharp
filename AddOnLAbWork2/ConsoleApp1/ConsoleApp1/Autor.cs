using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Autor
    {
        public string Name;
        int Year { get; set; }
        int YearDeath { get; set; }
        string Photo;

        public SortedSet<string> ISBNBooks;

        public Autor()
        {
            Name = "";
            Year = -1;
            YearDeath = -1;
            Photo = "";
            ISBNBooks = new SortedSet<string>();
        }

        public Autor(string name)
        {
            this.Name = name;
            this.Year = Year;
            YearDeath = -1;
            Photo = "";
            ISBNBooks = new SortedSet<string>();
        }

        public Autor(string name, int year, int yeardeath)
        {
            this.Name = name;
            this.Year = Year;
            this.YearDeath = yeardeath;
            YearDeath = -1;
            Photo = "";
            ISBNBooks = new SortedSet<string>();
        }

        //public void AddNewBook(string NewISBN)
        //{
        //    ISBNBooks.Add(NewISBN);
        //}

        //public SortedSet<string> GetListOfBooks()
        //{
        //    return ISBNBooks;
        //}

    }
}
