using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Selling
{
    internal class NewsPaper : Product
    {
        public int Advertisement;
        public string Article;

        public NewsPaper(int Advertisement, string Article, string ReleaseDate, int Price,int count) : base(ReleaseDate, Price,count)
        {
            this.Advertisement = Advertisement;
            this.Article = Article;
        }
        public void specificNwPaper()
        {
            Console.WriteLine($"Advertisement: {Advertisement}, Article: {Article}");
        }
        public void sameFeature()
        {
            Console.WriteLine($"NewsPaper - Relase Date: {ReleaseDate}, Price: {Price}$");
        }
        public void BooksellingProsses()
        {
            count--;
            if (count < 0 || count == 0)
            {
                Console.WriteLine("Qazetin Satis Prosesi Heyata Kecirilmedi...");
            }
            else
            {
                Console.WriteLine($"Qazetden {count}-eded qalib...");
            }
        }
    }
}
