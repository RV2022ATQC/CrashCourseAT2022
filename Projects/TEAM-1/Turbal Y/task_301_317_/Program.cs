
using System;

namespace task_301_317
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Shop shop = new Shop();
      shop.Add(1, "Renault Cadjar", 11000f, 5);
      Console.WriteLine("size= " + (object) shop.size + " " + shop.Goods[shop.size - 1].Name + " " + (object) shop.Goods[shop.size - 1].cost + " " + (object) shop.Goods[shop.size - 1].count);
      shop.Sell(1, 2);
      Console.WriteLine("size= " + (object) shop.size + " " + shop.Goods[shop.size - 1].Name + " " + (object) shop.Goods[shop.size - 1].cost + " " + (object) shop.Goods[shop.size - 1].count);
      Console.ReadLine();
    }
  }
}
