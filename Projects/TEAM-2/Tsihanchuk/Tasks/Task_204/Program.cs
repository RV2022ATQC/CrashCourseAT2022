using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _204
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишіть програму, яка обчислює квадрат будь-якого, введеного числа.
            Console.WriteLine("Number is: ");
            string number = Console.ReadLine();

            float square = (float)Math.Pow(Convert.ToSingle(number), 2);

            Console.WriteLine($"{square} i square of { number}");

               


        }
    }
}
