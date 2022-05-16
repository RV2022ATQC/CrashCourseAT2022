using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task301.Classes;

namespace Task301
{
    class Program
    {
        //Написати клас Товар.Також реалізувати клас магазин.
        //Передбачити можливість отримання товару на баланс і продажу товару.
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            int choice = 0;

            Product prod1 = new Product(1, "milk", 20, "white and delicious", "29867M");
            Product prod2 = new Product(2, "banana", 50, "sweet and flavory", "393412B");
            Product prod3 = new Product(3, "cake", 120, "chocolate and taste", "69345С");

            shop.addProduct(prod1);
            shop.addProduct(prod2);
            shop.addProduct(prod3);

            do
            {
                Console.WriteLine("\n\t~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ M E N U  ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ " +
                    "\n  1. Add new product to your shop." +
                    "\n  2. Delete product from your shop." +
                    "\n  3. Show your shop." +
                    "\n  4. Exit.\n\n");
                Console.Write(" Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Product newProduct = new Product();
                            Console.Write(" Enter name for new product: ");
                            newProduct.setName(Console.ReadLine());
                            Console.Write(" Enter price for new product: ");
                            newProduct.setPrice(float.Parse(Console.ReadLine()));
                            Console.Write(" Enter some description for new product: ");
                            newProduct.setDescription(Console.ReadLine());
                            Console.Write(" Enter acticul for new product: ");
                            newProduct.setArticul(Console.ReadLine());
                            newProduct.setId(shop.getSize() + 1);
                            shop.addProduct(newProduct);

                            if (shop.GetList().Contains(newProduct))
                            {
                                Console.WriteLine("New product added to shop!");
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Write(" Enter id product, which you want to delete: ");
                            int id = Int32.Parse(Console.ReadLine());
                            shop.deleteProd(id);
                            var delProd = shop.GetList().FirstOrDefault(x => id == x.getId());
                            if (!shop.GetList().Contains(delProd))
                            {
                                Console.WriteLine($"Product deleted from shop!");
                            }
                            break;
                        }
                    default:
                    case 3:
                        {
                            shop.printList();
                            break;
                        }
                    case 4:
                        {
                            choice = -1;
                            Console.WriteLine(" ~ You're out!");
                            break;
                        }
                }
            } while (choice != -1);
        }
    }
}
