using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_202
{
    internal class Program
    {   //2. Напишіть програму, яка переводить гривні в $, Є.
        static void Main(string[] args)
        {
            float usd = 0;
            Console.Write("USD: ");
            usd = Int32.Parse(Console.ReadLine());

            Console.Write("In dolar " +Math.Round(usd / 29.6,2 ));
            Console.WriteLine("\nIn evro " + Math.Round(usd / 32.1, 2));
        }
    }
}
