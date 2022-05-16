// Мерцалова Ірина, Мосійчук Юрій
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public DateTime Date { get; set; }
        public string DeclarationNumber { get; set; }
        public bool IsCompeleted { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        private static int counter = 0;

        public Order(string declarationNumber, DateTime date, string customer, List<OrderItem> orderItems)
        {
            Id = counter;
            counter++;
            IsCompeleted = false;
            DeclarationNumber = declarationNumber;
            Date = date;
            Customer = customer;
            OrderItems = orderItems;
        }

        public void AddOrderItem(OrderItem newItem)
        {
            OrderItems.Add(newItem);
        }

        // removing by name
        public void RemoveOrderItem(string name)
        {
            OrderItems.Remove(OrderItems.FirstOrDefault(x => x.ItemName == name));
        }

        // removing by id
        public void RemoveOrderItem(int id)
        {
            OrderItems.Remove(OrderItems.FirstOrDefault(x => x.Id == id));
        }

        public void ChangeStaus(bool status)
        {
            IsCompeleted = status;
        }

        public override string ToString()
        {
            string items = "";
            foreach (var item in OrderItems)
            {
                items += "\nItem: " + item.ItemName + "\tAmount: " + item.Amount + "\tPrice: " + item.Price;
            }
            return ("Id: " + Id + "\tDeclaration number" + DeclarationNumber + "\tIs compeleted: " + IsCompeleted + "\tCustomer: " + Customer + "\tDate: " + Date + items);
        }

    }
}
