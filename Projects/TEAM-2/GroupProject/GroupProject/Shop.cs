// Влад Клопотенко
// Not finised yet. I need to add showing items in ascending order id to void ShowItems()
using System;
using System.Collections.Generic;

namespace TeamTask
{
    public class Shop
    {
        List<Item> items = new List<Item>;

        public void AddItem(int id, string name, int amount, decimal price)
        {
            bool noExist = true;
            for (int i = 0; i < items.Count; i++)
            {
                if (id == items[i].id || name == items[i].name)
                {
                    items[i].amount++;
                    Console.WriteLine($"This item has already exist whith ID: {items[i].id}. Now amount is {items[i].amount}");
                    noExist = false;
                    break;
                }
            }
            if (noExist)
            {
                items.Add(new Item(id, name, amount, price));
            }
        }

        public void RemoveItem(int id) // removing item by id
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (id == items[i].id)
                {
                    items.RemoveAt(i);
                    Console.WriteLine($"Item with ID: {items[i].id} has been removed");
                    break;
                }
            }
        }

        public void RemoveItem(string name) // removing item by name
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (name == items[i].name)
                {
                    items.RemoveAt(i);
                    Console.WriteLine($"Item with name: {items[i].name} has been removed");
                    break;
                }
            }
        }

        public void ChangeItem(int id, string name, int amount, decimal price) // Changing by id. You enter id to find item and you can't change the id. You enter new name, amount and price to change them.
        {
            bool noExist = true;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].id == id)
                {
                    items[i].name = name;
                    items[i].amount = amount;
                    items[i].price = price;
                    noExist = false;
                    Console.WriteLine($"Item with ID: {items[i].id} was changed. Now it looks {items[i].ShowItem()}");
                    break;
                }
            }
            if (noExist)
            {
                Console.WriteLine($"Item with ID: {id} isn't exist!");
            }
        }

        public void ShowItems()
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine("====Avalible items====");
                Console.WriteLine(items[i].ShowItem());
            }
        }

        public void FindItem(int id) // finding item (showing it) by id
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].id == id)
                {                   
                    Console.WriteLine(items[i].ShowItem());
                    break;
                }
            }
        }

        public void FindItem(string name) // finding item (showing it) by name
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].name == name)
                {
                    Console.WriteLine(items[i].ShowItem());
                    break;
                }
            }
        }
    }
}
