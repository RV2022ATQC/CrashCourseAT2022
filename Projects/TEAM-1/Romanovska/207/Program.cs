using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _207
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Дано натуральне число а (a <100). 
              Напишіть програму, що виводить на екран кількість цифр в цьому числі і суму цих цифр*/

            Console.Write("Enter any number < 100: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 100)
            {
                if (a > 9)
                {
                    Console.WriteLine("Two numbers");
                    Console.WriteLine($"Sum:  {a / 10} + {a % 10} = {(a / 10) + (a % 10)}");
                }
                else
                {
                    Console.WriteLine("One number");
                    Console.WriteLine($"Sum = {a}");
                }
            }

        }
    }
}
