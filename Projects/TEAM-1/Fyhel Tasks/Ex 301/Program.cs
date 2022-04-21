using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_301
{
    //Написати клас Товар. Також реалізувати клас магазин.
    //Передбачити можливість отримання товару на баланс і продажу товару.
    class Program
    {

        static int EnterNumber()// my funk for corect inputing integer
        {
            string tempStr = Console.ReadLine();
            int number = 1;
            bool isComplate = false;
            while (!isComplate && number>=0)
            {
                try
                {
                    number = int.Parse(tempStr);
                    isComplate = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong input, try again");
                    tempStr = Console.ReadLine();
                }
            }
            return number;
        }

        static string EnterString()// my funk for corect inputing string
        {
            string tempStr = Console.ReadLine();
            while (tempStr.Length == 0)
            {
                Console.WriteLine("Wrong input, try again");
                tempStr = Console.ReadLine();
            }
                return tempStr;
        }


        class Item
        {
            public int id;
            public string name;
            public string deskription;
            public float cost;
            public int amount;

            public Item(int id, string name, string deskription, float cost, int amount)
            {
                this.id = id;
                this.name = name;
                this.deskription = deskription;
                this.cost = cost;
                this.amount = amount;
            }
            public Item(int id)
            {
                this.id = id;
                this.name = "undefined";
                this.deskription = "undefined";
                this.cost = -1;
                this.amount = -1;
            }
        }



        class Market// my class
        {

            private List<Item> balanceGoods = new List<Item>();

            public void fillMarket()//temp//this function is required for the test
            {
                balanceGoods.Add(new Item(1, "vanish", "wash powder", 243, 15));
                balanceGoods.Add(new Item(2, "gloves", "rubber", 39, 70));
                balanceGoods.Add(new Item(3, "table", "wooden", 1699 , 3));
            }


            public void printGoods()
            {
                if (balanceGoods.Count()!=0)
                {              
                    Console.WriteLine("no|   name   | deskription |amount| cost |");
                    foreach(var i in balanceGoods)
                    {

                        Console.Write("{0,2}",i.id);
                        Console.Write( i.name.PadLeft(10));
                        Console.Write(i.deskription.PadLeft(14));
                        Console.Write("{0,7}", i.amount);
                        Console.WriteLine("{0,7}", i.cost);
                    }
                }
            }


            public void sellGood(string name = "", int id = 0, int amount = 0)
            {
                bool isDeleted = false;
                string tempStr;
               /////////////manual input
                if (name.Length == 0 && id ==0)//if we didn't get anything from calling fynction
                {
                    Console.WriteLine("Enter name or good's no:");
                    tempStr = Console.ReadLine();
                    try
                    {
                        id = int.Parse(tempStr) -1;
                    }
                    catch
                    {
                        name = tempStr;
                    }
                    Console.WriteLine("Enter quantity of goods on sold:");
                    amount = EnterNumber();
                }
                /////////end of manual input
                if (id != 0&&id<=balanceGoods.Count)//selling by id
                {
                    if (balanceGoods[id].amount <= amount)
                        balanceGoods.RemoveAt(id - 1);
                    else
                        balanceGoods[id - 1].amount = balanceGoods[id - 1].amount - amount;
                    isDeleted = true;
                }
                else if (name.Length != 0)//selling by name
                {

                    foreach (var i in balanceGoods)
                        if (i.name.Equals(name))
                        {
                            if (balanceGoods[i.id-1].amount <= amount)
                                balanceGoods.RemoveAt(i.id-1);
                            else
                                balanceGoods[i.id-1].amount = balanceGoods[i.id-1].amount - amount;
                            isDeleted = true;
                            break;
                        }
                }
                else
                    Console.WriteLine("There is no parameters!!!");
                
                if (!isDeleted)//just message
                    Console.WriteLine("balance wasn't changed.");
                else
                { 
                    Console.WriteLine("balance was changed.\n\n");
                    for (int i = 0; i < balanceGoods.Count; i++)//changing no: collone
                        balanceGoods[i].id = i + 1;
                    printGoods();//changed goods
                }
            }


            public void addGood(Item item=null)
            {
            ///////manual input
                if(item == null)//if we don't get anything from function
                {
                    item = new Item(id : balanceGoods.Count+1);

                    Console.WriteLine("Enter name:");
                    item.name = EnterString();
                    Console.WriteLine("Enter deskription:");
                    item.deskription = EnterString();
                    Console.WriteLine("Enter amount:");
                        item.amount = EnterNumber();
                    Console.WriteLine("Enter cost:");
                    item.cost = EnterNumber();
                }
            ///////end of manual input
                balanceGoods.Add(item);
                Console.WriteLine($"we add {item.amount} {item.name}'s by {item.cost}$ for everyone.\n\n");
                printGoods();
            }
        }

        static void Main(string[] args)
        {
            Market market = new Market();
            int varriant = -1; 
            market.fillMarket();//only for development

            Console.WriteLine("Print :\n\n1  -  to see all goods\n2  -  to add new good\n3  -  to sell smth\n4  -  EXIT");//manual menu
            do
            {
                varriant = EnterNumber();
                if (varriant == 1)
                    market.printGoods();
                else if (varriant == 2)
                    market.addGood();
                else if (varriant == 3)
                    market.sellGood();
                else
                    Console.WriteLine("Wrong varriat, choose from 1 , 2 or 3");
            }
            while (varriant != 4);
        }
    }
}
