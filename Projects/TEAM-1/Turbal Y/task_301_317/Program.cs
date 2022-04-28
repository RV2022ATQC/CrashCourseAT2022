// Decompiled with JetBrains decompiler
// Type: task_301_317.Program
// Assembly: task_301_317, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5FE86C26-2ACF-4579-A1C5-2F38368FB7E0
// Assembly location: C:\Users\Marshall\Downloads\task_301_317.exe

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
