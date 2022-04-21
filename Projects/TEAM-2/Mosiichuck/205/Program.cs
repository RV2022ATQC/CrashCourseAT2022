using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _205
{
    class Program
    {
        // Введіть три числа і виведіть на екран значення суми і добуток цих чисел
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter num1: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter num3: ");
            num3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Sum of 3 elements is " + (num1 + num2 + num3));
            Console.WriteLine("Product of 3 elements is " + (num1 * num2 + num3));
        }
    }
}
