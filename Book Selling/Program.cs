using System;

namespace Book_Selling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ReleaseDate="10.01.1985";
            int Price=100;
            int count = 1;
            string Author="Anonim";
            string Genre= "Comedy";
            int Advertisement=4;//Reklamlarin sayini nezerde tutmusammm
            string Article="Salam BAKI";

            Product product = new Product(ReleaseDate,Price,count);
            Book book = new Book(Author, Genre, ReleaseDate, Price,count);
            Console.WriteLine("Book");
            book.specificBook();
            NewsPaper NwP = new NewsPaper(Advertisement, Article, ReleaseDate="12.03.2022", Price = 1,count=1);
            Console.WriteLine("NewsPaper");
            NwP.specificNwPaper();
            Console.WriteLine("Same Feature");
            book.sameFeature();
            NwP.sameFeature();
            Console.WriteLine("Selling");
            book.BooksellingProsses();
            NwP.BooksellingProsses();

        }
    }
}
