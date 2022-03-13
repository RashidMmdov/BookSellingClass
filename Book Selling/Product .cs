using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Selling
{
    internal class Product
    {
        public string ReleaseDate;
        public int Price;
        public int count;

        public Product(string ReleaseDate, int Price ,int count)
        {
            this.ReleaseDate = ReleaseDate;
            this.Price = Price;
            this.count = count;
            
        }
        
      
    }
}
