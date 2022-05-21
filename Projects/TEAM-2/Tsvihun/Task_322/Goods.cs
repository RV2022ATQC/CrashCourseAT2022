using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_322
{
    internal class Goods
    {
        #region Fields
        public string Name { get; set; }
        public decimal EntryPrice { get; set; }
        public DateTime EntryDate { get; set; }
        public int Count { get; set; }
        #endregion

        public Goods(string name, decimal price, DateTime date, int amount)
        {
            Name = name;
            EntryPrice = price;
            EntryDate = date;
            Count = amount;
        }

        #region Input Fields
        public void SetName()
        {
            Console.WriteLine("Enter item name:");
            Name = Console.ReadLine();
        }
        public void SetEntryPrice()
        {
            decimal price;
            Console.WriteLine("Enter item entry price:");
            while (!decimal.TryParse(Console.ReadLine(), out price))
                Console.WriteLine("Incorrent number!");
            EntryPrice = price;
        }

        public void SetEntryDate()
        {
            DateTime date;
            Console.WriteLine("Enter entry date (mm/dd/yy):");
            while (!DateTime.TryParse(Console.ReadLine(), out date))
                Console.WriteLine("Incorrent date!");
            EntryDate = date;
        }

        public void SetQuantity()
        {
            int count;
            Console.WriteLine("Enter amount of items:");
            while (!int.TryParse(Console.ReadLine(), out count))
                Console.WriteLine("Incorrent number!");
            Count = count;
        }
        #endregion

        #region Output Fields
        public void ShowName() { Console.WriteLine($"Item name: {Name}"); }
        public void ShowEntryPrice() { Console.WriteLine($"Item entry price: {EntryPrice}"); }
        public void ShowEntryDate() { Console.WriteLine($"Entry date: {EntryDate}"); }
        public void ShowAmount() { Console.WriteLine($"Item balance: {Count}"); }
        #endregion

        public override string ToString()
        {
            return $"{Name}\nQuantity: {Count}\nPrice: {EntryPrice}\nEntryDate: {EntryDate}";
        }
    }
}
