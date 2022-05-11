// Влад Клопотенко

using System;
using System.Collections.Generic;

namespace TeamTask
{
    public class Shop
    {
        List<Item> items = new List<Item>();

        public void AddItem(string name, double price, string creator, uint quantity)
        {
            bool noExist = true;
            for (int i = 0; i < items.Count; i++)
            {
                if (name == items[i].name)
                {
                    items[i].amount++;
                    Console.WriteLine($"This item has already exist whith ID: {items[i].id}. Now amount is {items[i].amount}");
                    noExist = false;
                    break;
                }
            }
            if (noExist)
            {
                items.Add(new Item(name, price, creator, quantity));
            }
        }

        public void RemoveItem(int id) // removing item by id
        {
            bool noExist = true;
            for (int i = 0; i < items.Count; i++)
            {
                if (id == items[i].id)
                {
                    items.RemoveAt(i);
                    Console.WriteLine($"Item with ID: {items[i].id} has been removed");
                    noExist = false;
                    break;
                }
            }
            if (noExist)
            {
                Console.WriteLine($"Item with ID: {id} isn't exist!");
            }
        }

        public void RemoveItem(string name) // removing item by name
        {
            bool noExist = true;
            for (int i = 0; i < items.Count; i++)
            {
                if (name == items[i].name)
                {
                    items.RemoveAt(i);
                    Console.WriteLine($"Item with name: {items[i].name} has been removed");
                    noExist = false;
                    break;
                }
            }
            if (noExist)
            {
                Console.WriteLine($"Item with name: {name} isn't exist!");
            }
        }

        public void ChangeItem(int id, string name, double price, string creator, uint quantity) // Changing by id. You enter id to find item and you can't change the id. You enter new name, amount and price to change them.
        {
            bool noExist = true;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].id == id)
                {
                    items[i].name = name;
                    items[i].price = price;
                    items[i].creator = creator;
                    items[i].quantity = quantity;
                    noExist = false;
                    Console.WriteLine($"Item with ID: {items[i].id} was changed. Now it looks {items[i].ToString()}");
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
            bool noExist = true;
            Console.WriteLine("====Avalible items====");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i].ToString());
                noExist = false;
            }
            if (noExist)
            {
                Console.WriteLine("No avalible items!");
            }
        }

        public void FindItem(int id) // finding item (showing it) by id
        {
            bool noExist = true;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].id == id)
                {                   
                    Console.WriteLine(items[i].ToString());
                    noExist = false;
                    break;
                }
            }
            if (noExist)
            {
                Console.WriteLine($"Item with ID: {id} isn't exist!");
            }
        }

        public void FindItem(string name) // finding item (showing it) by name
        {
            bool noExist = true;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].name == name)
                {
                    Console.WriteLine(items[i].ToString());
                    noExist = false;
                    break;
                }
            }
            if (noExist)
            {
                Console.WriteLine($"Item with name: {name} isn't exist!");
            }
        }
    }
}
