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
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int Amount { get; set; }
        public float Price { get; set; }
        private static int counter = 0;

        public OrderItem(string itemName, int amount, float price)
        {
            Id = counter;
            counter++;
            ItemName = itemName;
            Amount = amount;
            Price = price;            
        }
    }
}
