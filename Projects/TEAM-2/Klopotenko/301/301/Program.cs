using System;

namespace _301
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            shop.AddItem(1, "iPhone 13", 999.99, 2);
            shop.AddItem(2, "iPhone Case", 8.21, 26);
            shop.AddItem(3, "AirPods", 129.98, 5);
            shop.AddItem(4, "Laptop", 1392.11, 1);
            shop.AddItem(5, "Pad", 500, 0);
            shop.AddItem(6, "Keyboard", 99.99, 3);
            shop.sellGoods(2, 1);
            shop.sellGoods("iPhone Case", 2);
            shop.ShowItems();
        }
    }
}
