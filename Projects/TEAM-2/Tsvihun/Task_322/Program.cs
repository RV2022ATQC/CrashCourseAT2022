using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_322
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Goods cup = new Goods("Cup", 40, new DateTime(2021,09,10), 20);
            Console.WriteLine(cup.ToString());
            //cup.ShowName();
            Console.WriteLine();

            
           

            // --------------------- //
            FoodGoods sugar = new FoodGoods("Sugar", 32, new DateTime(2022, 04, 20), 400, "Kg", new DateTime(2022,01,01), "365");
            //Console.WriteLine(sugar.ToString());
        /*    sugar.ShowName();
            sugar.ShowEntryPrice();
            sugar.ShowEntryDate();
            sugar.ShowAmount();
            sugar.ShowProductionDate();
            sugar.ShowShelfLife();

            sugar.SetName();
            sugar.SetEntryPrice();
            sugar.SetEntryDate();
            sugar.SetQuantity();
            sugar.SetPruductionDate();
            sugar.SetShelfLife();
        */
            Console.WriteLine(sugar.ToString());

            Console.WriteLine(sugar.GetExpirationDays());


        }
    }
}
