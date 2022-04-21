using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _204
{
    class Program
    {
        //Напишіть програму, яка обчислює квадрат будь-якого, введеного числа
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter number: ");
            num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Square of number " + num + " is " + (num * num));
        }
    }
}
