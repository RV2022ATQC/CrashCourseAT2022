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
            Goods goods = new Goods("Cup", 40, new DateTime(2021,09,10), 20);
            Console.WriteLine(goods.ToString());
        }
    }
}
