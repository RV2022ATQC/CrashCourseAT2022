using System;
using System.Collections.Generic;
using System.Text;

namespace Task_301
{
    internal class Shop
    {
        private List<Goods> goods = new List<Goods>();

        public void AddItem(string name, int price, int quantity)
        {            
            goods.Add(new Goods(name, price, quantity));
        }

        public void ShowItems()
        {
            foreach (Goods item in goods)
            {
                Console.WriteLine($"{item.name} - {item.quantity}");
            }
        }

        
    }
}
