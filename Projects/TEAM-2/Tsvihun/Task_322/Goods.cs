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
        public const string TYPE = "General product";
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
        public virtual void SetName()
        {
            Console.WriteLine("Enter item name:");
            Name = Console.ReadLine();
        }
        public virtual void SetEntryPrice()
        {
            decimal price;
            Console.WriteLine("Enter item entry price:");
            while (!decimal.TryParse(Console.ReadLine(), out price))
                Console.WriteLine("Incorrent number!");
            EntryPrice = price;
        }

        public virtual void SetEntryDate()
        {
            DateTime date;
            Console.WriteLine("Enter entry date (mm/dd/yy):");
            while (!DateTime.TryParse(Console.ReadLine(), out date))
                Console.WriteLine("Incorrent date!");
            EntryDate = date;
        }

        public virtual void SetQuantity()
        {
            int count;
            Console.WriteLine("Enter amount of items:");
            while (!int.TryParse(Console.ReadLine(), out count))
                Console.WriteLine("Incorrent number!");
            Count = count;
        }
        #endregion

        #region Output Fields
        public virtual void ShowName() { Console.WriteLine($"{TYPE}. {Name}"); }
        public virtual void ShowEntryPrice() { Console.WriteLine($"Entry price: {EntryPrice}"); }
        public virtual void ShowEntryDate() { Console.WriteLine($"Entry date: {EntryDate}"); }
        public  virtual void ShowAmount() { Console.WriteLine($"Balance: {Count}"); }
        #endregion

        public override string ToString()
        {
            return $"{TYPE}. {Name}\nQuantity: {Count}\nPrice: {EntryPrice}\nEntryDate: {EntryDate}";
        }
    }
}
