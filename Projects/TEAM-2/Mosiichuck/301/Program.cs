using System;

namespace _301
{
    class Program
    {
        //Написати клас Товар. Також реалізувати клас магазин. Передбачити можливість отримання товару на баланс і продажу товару.
        static void Main(string[] args)
        {
            Product product1 = new Product(12.12, "Juice");
            Product product2 = new Product(3.03, "Bread");
            Product product3 = new Product(4.05, "Black bread");

            Shop shop = new Shop(); 
            shop.AddProduct(product1);
            shop.AddProduct(product2);
            shop.AddProduct(product3);

            Console.WriteLine();
            shop.ShowProducts();

            Console.WriteLine();
            Console.Write("Enter Id of product to delete it: ");
            shop.DeleteProduct(Int32.Parse(Console.ReadLine()));

            double price;
            string name;
            Console.WriteLine();
            Console.Write("Enter name of product: ");
            name = Console.ReadLine();
            Console.Write("Enter price of product: ");
            price = Double.Parse(Console.ReadLine());
            shop.AddProduct(new Product(price,name));

            Console.WriteLine();
            shop.ShowProducts();
        }
    }
}
