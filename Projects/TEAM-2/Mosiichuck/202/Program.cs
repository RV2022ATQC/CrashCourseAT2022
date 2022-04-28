using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202
{
    class Program
    {
        //Напишіть програму, яка переводить гривні в $, Є
        static void Main(string[] args)
        {
            float grn = 0;
            Console.Write("Enter money: ");
            grn = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nYour money " + grn + "UAN \nUSD (29.24): " +
               +(float)Math.Round(grn / 29.24, 2) + "\nEUR (31,68): " +
               +(float)Math.Round(grn / 31.68, 2) + "\n");
        }
    }
}
