﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5. Введіть три числа і виведіть на екран значення суми і добуток цих чисел.
namespace _205
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(a1 + b1 + c1);
            Console.WriteLine(a1 * b1 * c1);
        }
    }
}
