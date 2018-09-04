using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Book
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public int Size { get; set; }
        public string ISBN;
     //   int[] Autors;
     //   string Publisher;
     //   string[] Tegs;

        public Book(string number, string name, int year, int size)
        {
            this.ISBN = number;
            this.Name = name;
            this.Year = year;
            this.Size = size;
        }

        public Book()
        {
            this.ISBN = "";
            this.Name = "NoName";
            this.Year = -1;
            this.Size = 0;
        }

    }
}
