using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task213
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int k = 1, b = a;
            while (a >= 10)
            {
                a /= 10;
                k *= 10;
            }
            a = b;
            b = 0;
            while (a >= 1)
            {
                b += (a % 10) * k;
                a /= 10;
                k /= 10;
            }
            Console.WriteLine($"New number: {b}");
        }
    }
}
