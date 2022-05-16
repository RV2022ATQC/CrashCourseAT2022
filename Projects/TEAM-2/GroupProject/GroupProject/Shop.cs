// Влад Клопотенко

using System;
using System.Collections.Generic;

namespace GroupProject

{
    public class Shop
    {
        List<Item> items = new List<Item>();

        public void AddItem(string name, double price, string creator, uint quantity)
        {
            bool noExist = true;
            for (int i = 0; i < items.Count; i++)
            {
                if (name == items[i].Name)
                {
                    items[i].Quantity++;
                    Console.WriteLine($"This item has already exist whith ID: {items[i].ID}. Now amount is {items[i].Quantity}");
                    noExist = false;
                    break;
                }
            }
            if (noExist)
            {
                items.Add(new Item(name, price, creator, quantity));
            }
        }

        // removing item by id
        public void RemoveItem(int id)
        {
            bool noExist = true;
            for (int i = 0; i < items.Count; i++)
            {
                if (id == items[i].ID)
                {
                    items.RemoveAt(i);
                    Console.WriteLine($"Item with ID: {items[i].ID} has been removed");
                    noExist = false;
                    break;
                }
            }
            if (noExist)
            {
                Console.WriteLine($"Item with ID: {id} isn't exist!");
            }
        }

        // removing item by name
        public void RemoveItem(string name) 
        {
            bool noExist = true;
            for (int i = 0; i < items.Count; i++)
            {
                if (name == items[i].Name)
                {
                    items.RemoveAt(i);
                    Console.WriteLine($"Item with name: {items[i].Name} has been removed");
                    noExist = false;
                    break;
                }
            }
            if (noExist)
            {
                Console.WriteLine($"Item with name: {name} isn't exist!");
            }
        }

        // Changing by id. You enter id to find item and you can't change the id. You enter new name, amount and price to change them.
        public void ChangeItem(int id, string name, double price, string creator, uint quantity)
        {
            bool noExist = true;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ID == id)
                {
                    items[i].Name = name;
                    items[i].Price = price;
                    items[i].Creator = creator;
                    items[i].Quantity = quantity;
                    noExist = false;
                    Console.WriteLine($"Item with ID: {items[i].ID} was changed. Now it looks {items[i].ToString()}");
                    break;
                }
            }
            if (noExist)
            {
                Console.WriteLine($"Item with ID: {id} isn't exist!");
            }
        }

        // showing all items list
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

        // finding item (showing it) by id
        public void FindItem(int id)
        {
            bool noExist = true;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ID == id)
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

        // finding item (showing it) by name
        public void FindItem(string name)
        {
            bool noExist = true;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Name == name)
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
