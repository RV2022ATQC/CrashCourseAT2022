// Decompiled with JetBrains decompiler
// Type: task_301_317.Shop
// Assembly: task_301_317, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5FE86C26-2ACF-4579-A1C5-2F38368FB7E0
// Assembly location: C:\Users\Marshall\Downloads\task_301_317.exe

using System;

namespace task_301_317
{
  internal class Shop
  {
    public int size;
    public Product[] Goods;

    public Shop(int _size)
    {
      this.size = _size;
      this.Goods = new Product[1];
    }

    public Shop() => this.size = 0;

    public int Add(int _Id, string _Name, float _cost, int _count)
    {
      Product product = new Product(_Id, _Name, _cost, _count);
      if (this.size == 0)
      {
        ++this.size;
        this.Goods = new Product[1];
        this.Goods[0] = product;
        return _Id;
      }
      foreach (Product good in this.Goods)
      {
        if (good.Id == _Id)
        {
          ++good.count;
          return _Id;
        }
      }
      ++this.size;
      Array.Resize<Product>(ref this.Goods, this.Goods.Length + 1);
      this.Goods[this.Goods.Length - 1] = product;
      return _Id;
    }

    public void Sell(int _Id, int _count)
    {
      if (this.size <= 0)
        return;
      foreach (Product good in this.Goods)
      {
        if (good.Id == _Id && good.count >= _count)
          good.count -= _count;
        else
          Console.WriteLine("absent");
      }
    }
  }
}
