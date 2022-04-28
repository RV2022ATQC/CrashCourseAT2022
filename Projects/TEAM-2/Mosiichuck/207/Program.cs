using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _207
{
    class Program
    {
        // Дано натуральне число а (a <100). Напишіть програму, що виводить на екран кількість цифр в цьому числі і суму цих цифр
        static void Main(string[] args)
        {
            int a;
            Console.Write("Enter a < 100: ");
            a = Int32.Parse(Console.ReadLine());
            if (a < 100)
            {
                if (a >= 10)
                {
                    Console.WriteLine("Two number");
                    Console.WriteLine("Sum: " + ((a / 10) + (a % 10)));
                }
                else
                {
                    Console.WriteLine("One number");
                    Console.WriteLine("Sum = " + a);
                }
            }
            else
                Console.WriteLine("Wrong data!");
        }
    }
}
