using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product apple = new Product();
            apple.productName = "Elma";
            apple.price = 15;
            apple.Id = 1;
            apple.description = "Amasya Elması";

            BasketManager manager = new BasketManager();
           
            manager.Add(apple);


            manager.Add2("Armut", "İri Armut", 12);

        }
    }
}
