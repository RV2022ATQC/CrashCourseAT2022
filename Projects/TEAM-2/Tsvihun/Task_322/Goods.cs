using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_322
{
    internal class Goods
    {
        public string Name { get; set; }
        public decimal EntryPrice { get; set; }
        public DateTime EntryDate { get; set; }
        public int Count { get; set; }

        public Goods(string name, decimal price, DateTime date, int amount)
        {
            Name = name;
            EntryPrice = price;
            EntryDate = date;
            Count = amount;
        }

        public override string ToString()
        {
            return $"{Name}\nQuantity: {Count}\nPrice: {EntryPrice}\nEntryDate: {EntryDate}";
        }
    }
}
