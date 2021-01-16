using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Tekrikler. Sepete eklendi:" + product.productName);
        }
        public void Add2(string productName,string description,double price)
        {
            Console.WriteLine("Tekrikler. Sepete eklendi:" + productName);
        }
    }
}
