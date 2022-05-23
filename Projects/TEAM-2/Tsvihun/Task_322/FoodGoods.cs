using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_322
{
    internal class FoodGoods : Goods
    {
        #region Fields
        public const string TYPE = "Food product";
        public string Units { get; set; }
        public DateTime ProductionDate { get; set; }
        public TimeSpan ShelfLife { get; set; }


        #endregion

        public FoodGoods(string name, decimal price, DateTime date, int amount, string units, DateTime productionDate, string shelfLifeDays)
            : base(name, price, date, amount)
        {
            Units = units;
            ProductionDate = productionDate;
            ShelfLife = TimeSpan.Parse(shelfLifeDays);
            BestBefore = ProductionDate.Add(ShelfLife);
        }

        #region Input Fields
        public override void SetName()
        {
            Console.WriteLine("Enter food name:");
            Name = Console.ReadLine();
        }
        public override void SetEntryPrice()
        {
            decimal price;
            Console.WriteLine("Enter food entry price:");
            while (!decimal.TryParse(Console.ReadLine(), out price))
                Console.WriteLine("Incorrent number!");
            EntryPrice = price;
        }

        public override void SetEntryDate()
        {
            DateTime date;
            Console.WriteLine("Enter food entry date (mm/dd/yy):");
            while (!DateTime.TryParse(Console.ReadLine(), out date))
                Console.WriteLine("Incorrent date!");
            EntryDate = date;
        }

        public override void SetQuantity()
        {
            int count;
            Console.WriteLine("Enter amount of food product:");
            while (!int.TryParse(Console.ReadLine(), out count))
                Console.WriteLine("Incorrent number!");
            Count = count;
        }
        public void SetPruductionDate()
        {
            DateTime date;
            Console.WriteLine("Enter food production date (mm/dd/yy):");
            while (!DateTime.TryParse(Console.ReadLine(), out date))
                Console.WriteLine("Incorrent date!");
            ProductionDate = date;
        }
        public void SetShelfLife()
        {
            Console.WriteLine("Enter food shelflife (in days):");
            ShelfLife = TimeSpan.Parse(Console.ReadLine());
        }
        #endregion


        #region Output Fields
        public override void ShowName() { Console.WriteLine($"Category: {TYPE}. {Name}."); }
        public override void ShowEntryPrice() { Console.WriteLine($"Product entry price: {EntryPrice}"); }
        public override void ShowEntryDate() { Console.WriteLine($"Product entry date: {EntryDate}"); }
        public override void ShowAmount() { Console.WriteLine($"Product balance: {Count} {Units}"); }
        public void ShowProductionDate() { Console.WriteLine($"Product made: {ProductionDate}"); }
        public void ShowShelfLife() { Console.WriteLine($"Product shelf life = {ShelfLife.Days} days"); }

        #endregion

        public override string ToString()
        {
            return $"- - - - - {TYPE}.{Name}\nPrice: {EntryPrice}\nEntryDate: {EntryDate}\nUnits: {Units}\nQuantity: {Count}\nMade: {ProductionDate}\nBest before: {BestBefore}";
        }

        public int GetExpirationDays()
        {
            var now = DateTime.Now;
            var edibleDays = (BestBefore - now).Days;
            if (edibleDays < 0)
            {
                Console.Write("Expired product! Days: ");
            }
            else Console.Write($"Days edible: ");
            return edibleDays;
        }





    }
}
