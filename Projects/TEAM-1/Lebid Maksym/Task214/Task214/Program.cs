using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task214
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (a >= 1)
            {
                sum += a % 10;
                a /= 10;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
