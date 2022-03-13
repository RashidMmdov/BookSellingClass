using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Selling
{
    internal class Book:Product
    {
        public string Author;
        public string Genre;


        public Book(string Author, string Genre, string ReleaseDate,int Price,int count):base(ReleaseDate, Price,count)
        {
            this.Author = Author;
            this.Genre = Genre;
           
        }
        public void specificBook()
        {
            Console.WriteLine($"Author: {Author}, Genre: {Genre}");
        }
        public void sameFeature()
        {
            Console.WriteLine($"Book - Relase Date: {ReleaseDate}, Price: {Price}$");
        }
        public void BooksellingProsses()
        {
            count--;
            if (count < 0 || count == 0)
            {
                Console.WriteLine("Kitabin Satis Prosesi Heyata Kecirilmedi...");
            }
            else
            {
                Console.WriteLine($"Kitabdan {count}-eded qalib...");
            }
        }
    }
}
