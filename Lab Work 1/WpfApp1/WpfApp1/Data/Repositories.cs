using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data
{
    class Repositories : IEnumerable
    {

        private static Dictionary<string, Book> Labriary;

        public static Dictionary<string, Book> GetLabriary()
        {
            Labriary = new Dictionary<string, Book>
            {
                ["4004"] = new Book("4004", "Harry Potter", 2001, 450),
                ["2102"] = new Book("2102", "The Witcher", 2010, 1200),
                ["1008"] = new Book("1008", "Game Of Trones", 2008, 520)
            };
            return Labriary;
        }

        public IEnumerator GetEnumerator()
        {
            return Labriary.GetEnumerator();
        }
    }
}
