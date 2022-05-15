// Мерцалова Ірина, Мосійчук Юрій
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public class OrderItem
    {
        public string ItemName { get; set; }
        public int Amount { get; set; }
        public float Price { get; set; }

        public OrderItem(string itemName, int amount, float price)
        {
            ItemName = itemName;
            Amount = amount;
            Price = price;
        }
    }
}
