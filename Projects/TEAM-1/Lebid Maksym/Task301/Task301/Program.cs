using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task301
{
    internal class Program
    {
        class Item
        {
            public string name;
            public float cost;
            public int amount;

            public Item(string name, float cost, int amount)
            {
                this.name = name;
                this.cost = cost;
                this.amount = amount;
            }
        }
        class Market
            {
                public float balance = 0;
                private List<Item> Stock = new List<Item>();

                public void AddGood()
                {

                    string name;
                    float cost;
                    int amount;
                    Console.WriteLine("Enter name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter cost: ");
                    cost = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Enter amount: ");
                    amount = Convert.ToInt32(Console.ReadLine());
                    Item item = new Item(name, cost, amount);

                    Stock.Add(item);
                }

                public  void ShowGoods()
                {
                    Console.WriteLine("Name | Cost | Amount");
                    if (Stock.Count > 0)
                    {
                        for (int i = 0; i < Stock.Count; i++)
                        {
                            Console.Write($"{Stock[i].name}; ");
                            Console.Write($"{Stock[i].cost}; ");
                            Console.WriteLine($"{Stock[i].amount}.");
                        }
                    }
                }

                public void SellGood()
                {
                    string name;
                    int amount;
                    bool sold = false;
                    Console.WriteLine("Enter name of good: ");
                    name = Console.ReadLine();

                    Console.WriteLine("Enter amount of good: ");
                    amount = Convert.ToInt32(Console.ReadLine());
                    if (name != null)
                    {
                        for(int i = 0; i < Stock.Count; i++)
                        {
                            if (Stock[i].name == name && Stock[i].amount >= amount)
                            {
                                balance += Stock[i].cost*amount;
                                Stock[i].amount -= amount;
                                if(Stock[i].amount < 0)
                                {
                                    Stock.RemoveAt(i);
                                }
                                Console.WriteLine($"You succesfully sold goods! Your balance: {balance}");
                                sold = true;
                            }
                        }

                        if (sold == false)
                        {
                            Console.WriteLine("There is no such goods, or amount of it is too small!");
                        }

                    }
                }
            }
        
        static void Main(string[] args)
        {
            Market market = new Market();
            int choice;
            Console.WriteLine("1 for add, 2 for show, 3 for sell, 4 for exit");
            do
            {
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1) market.AddGood();
                else if (choice == 2) market.ShowGoods();
                else if (choice == 3) market.SellGood();
            }
            while (choice != 4);
        }
    }
}
