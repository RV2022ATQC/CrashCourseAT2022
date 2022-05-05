using System;
namespace _301
{
    public class Goods
    {
        public int Id;
        public string Name;
        public double Price;
        public int Stock;

        public Goods(int Id, string Name, double Price, int Stock)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Stock = Stock;
        }
    }
}
