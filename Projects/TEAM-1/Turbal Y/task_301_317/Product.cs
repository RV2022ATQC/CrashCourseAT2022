// Decompiled with JetBrains decompiler
// Type: task_301_317.Product
// Assembly: task_301_317, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5FE86C26-2ACF-4579-A1C5-2F38368FB7E0
// Assembly location: C:\Users\Marshall\Downloads\task_301_317.exe

namespace task_301_317
{
  internal class Product
  {
    public int Id;

    public string Name { get; set; }

    public float cost { get; set; }

    public int count { get; set; }

    public Product(int _Id, string _Name, float _cost, int _count)
    {
      this.Id = _Id;
      this.Name = _Name;
      this.cost = _cost;
      this.count = _count;
    }

    public Product()
    {
      this.Id = 0;
      this.Name = " ";
      this.cost = 0.0f;
      this.count = 0;
    }
  }
}
