using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_202
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Напишіть програму, яка переводить гривні в $, Є.

            float usd = 0;

            Console.Write("USD: ");
            usd = Int32.Parse(Console.ReadLine());

            

            double evro = Math.Round(usd / 31.92,2);
            double dolar = Math.Round(usd / 29.32,2);

            Console.WriteLine("In dolar " + dolar + "\nIn evro " + evro );
        }
    }
}
