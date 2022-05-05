using System;
using System.Collections.Generic;

namespace _301
{
    public class Shop
    {
        List<Goods> goods = new List<Goods>();
        public void AddItem(int Id, string Name, double Price, int Stock)
        {
            bool isInStock = false;
            for (int i = 0; i < goods.Count; i++)
            {
                if(Name == goods[i].Name)
                {
                    isInStock = true;
                    goods[i].Stock++;
                    break;
                }
            }
            if (!isInStock)
            {
                goods.Add(new Goods(Id, Name, Price, Stock));
            }
            Console.WriteLine($"Added {Stock} of {Name}");
        }
        public void sellGoods(int Id, int Stock)
        {
            for(int i = 0; i < goods.Count; i++)
            {
                if(goods[i].Id == Id)
                {
                    goods[i].Stock -= Stock;
                }
            }
            Console.WriteLine($"Sold {Stock} of goods with Id: {Id}");
        }
        public void sellGoods(string Name, int Stock)
        {
            for (int i = 0; i < goods.Count; i++)
            {
                if (goods[i].Name == Name)
                {
                    goods[i].Stock -= Stock;
                }
            }
            Console.WriteLine($"Sold {Stock} of {Name}");
        }
        public void ShowItems()
        {
            Console.WriteLine("ITEMS IN THE SHOP:");
            foreach (Goods item in goods)
            {
                Console.WriteLine($"Item ID: {item.Id}  Price: {item.Price}  Name: {item.Name}  Stock: {item.Stock}");
            }
        }
    }
}
