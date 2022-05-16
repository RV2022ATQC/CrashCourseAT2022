// 300 КОМАНДРА РОБОТА:
// розробити кілька пов'язаних класів, які можуть між собою взаємодіяти;
// в програмі реалізувати ініціалізацію і взаємодію об'єктів розроблених класів;
// кожен член команди має розробити принаймні один клас; бажаною є наявність ієрархієї класів
// (якщо вдасться, то взаємодію класів організуйте через інтерфейси*)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop ourShop = new Shop();
            Order privateOrder1 = new Order("ABC_001", new DateTime(2022, 05, 10), "Ivanka Boghun", new List<OrderItem>(1));

            ourShop.AddItem("iPhone", 700, "Antonio", 3);
            ourShop.AddItem("iPhone", 700, "Antonio", 3);

            ourShop.ShowItems();

            ourShop.AddItem("Samsung Galaxy A20", 300, "Resailer", 4);
            ourShop.AddItem("iPhone 12", 800, "Apple store Kyiv", 10);

            ourShop.ShowItems();

            ourShop.FindItem(2);
            ourShop.FindItem("iPhone");

            Console.WriteLine("---------------------");
            Console.WriteLine("");
            
            
            
            Console.WriteLine(privateOrder1.ToString());

            









        }
    }
}
