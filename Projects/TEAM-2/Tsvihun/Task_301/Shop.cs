using System;
using System.Collections.Generic;

namespace Task_301
{
    internal class Shop
    {
        private List<Goods> goods = new List<Goods>();

        public void AddItem(string name, int price, int quantity)
        {
            bool itemIsPresent = false;
            for (int i = 0; i < goods.Count; i++)
            {
                if (name == goods[i].name)
                {
                    itemIsPresent = true;
                    goods[i].quantity += quantity;
                    break;
                }
            }
            if (!itemIsPresent)
            {
                goods.Add(new Goods(name, price, quantity));
            }
            Console.WriteLine($"Added {quantity} of {name} !");
        }

        public void SellItem(string name, int quantity)
        {
            //1 - Find item by name. Remove specified amount of them
            for (int i = 0; i < goods.Count; i++)
            {
                if (name == goods[i].name)
                {
                    goods[i].quantity -= quantity;
                    Console.WriteLine($"Removed {quantity} of {name} !");
                }
            }
        }

        public void ShowItems()
        {
            Console.WriteLine("--- Goods in shop: ---");
            foreach (Goods item in goods)
            {
                Console.WriteLine($"{item.name} - {item.quantity}");
            }
            Console.WriteLine("----------------------");
        }
    }
}
