using AddOnLabWork1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class Repository
    {
        
        private static MapForAutors ListOfAutors;
        private static MapForPublisher ListOfPublishers;
        public static MyLibrary<string, Book> ListOfBooks;

        static Repository()
        {
            ListOfBooks = new MyLibrary<string, Book>();
            ListOfAutors = new MapForAutors();
            ListOfPublishers = new MapForPublisher();
        }

        public static void GetNewBook()
        {
            Book nb = new Book("4569", "Informatics", 2016, 560, "Star");
            Autor na = new Autor("Petya");

            na.ISBNBooks.Add(nb.ISBN);
            if (!ListOfPublishers.Contains(nb.Publisher))
            {
                ListOfPublishers.Add(new Publisher(nb.Publisher, nb.ISBN));
            }
            else
            {
                ListOfPublishers[nb.Publisher].ISBNBooks.Add(nb.ISBN);
            }

            if (!ListOfAutors.Contains(na))
            {
                ListOfAutors.Add(na);
            }
            else
            {
                ListOfAutors[na.Name].ISBNBooks.Add(nb.ISBN);
            }
            nb.KeyOfAutors.Add(na.Name);
            ListOfBooks.Add(nb.ISBN,nb);

          //  ListOfBooks["4569"].Name = "Rtre";

            foreach(DictionaryEntry val in ListOfBooks)
            {
                Book t = (Book)val.Value;
                Console.WriteLine(t.Name);
            }
        }
   
        public static void GetNewPublisher(int year, string town, string name)
        {
            Publisher NewPublisher = new Publisher(year, town, name);
            if (!ListOfPublishers.Contains(NewPublisher))
                ListOfPublishers.Add(NewPublisher);
        }

        public static void GetNewAutor(string name, params int[] years)
        {
            Autor NewAutor  = new Autor(name, years[0], years[1]);
            if (!ListOfAutors.Contains(NewAutor))
                ListOfAutors.Add(NewAutor);
        }

        private class MapForAutors : KeyedCollection<string, Autor>
        {
            protected override string GetKeyForItem(Autor item)
            {
                return item.Name;
            }
        }

        private class MapForPublisher : KeyedCollection<string, Publisher>
        {
            protected override string GetKeyForItem(Publisher item)
            {
                return item.Name;
            }
        }
    }
}
