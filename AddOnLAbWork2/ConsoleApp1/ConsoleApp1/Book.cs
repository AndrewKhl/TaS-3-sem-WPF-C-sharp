using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddOnLabWork1
{
    class Book 
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public int Size { get; set; }
        public string ISBN { get; set; }
        public string Publisher { get; set; }
        public SortedSet<string> KeyOfAutors { get; private set; }
        public SortedSet<string> Tegs { get; private set; }

        public Book(string number, string name, int year, int size, string Publisher)
        {
            this.ISBN = number;
            this.Name = name;
            this.Year = year;
            this.Size = size;
            this.Publisher = Publisher;
            KeyOfAutors = new SortedSet<string>();
            Tegs = new SortedSet<string>();
        }

        public Book()
        {
            this.ISBN = "";
            this.Name = "NoName";
            this.Year = -1;
            this.Size = 0;
            KeyOfAutors = new SortedSet<string>();
            Tegs = new SortedSet<string>();
        }

        //public void AddAutor(int Key)
        //{
        //    KeyOfAutors.Add(Key);       
        //}

        //public void AddTeg(string NewTeg)
        //{
        //    Tegs.Add(NewTeg);   
        //}

        //public SortedSet<int> GetListOfAutors()
        //{
        //    return KeyOfAutors;
        //}

        //public SortedSet<string> GetListOfTegs()
        //{
        //    return Tegs;
        //}
    }
}
