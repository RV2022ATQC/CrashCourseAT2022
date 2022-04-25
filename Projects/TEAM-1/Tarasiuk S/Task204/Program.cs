using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            Double number = 0;
            number = Convert.ToSingle(Console.ReadLine());

            Double square = number * number;
       
            Console.WriteLine($"{number}*{number}={square}");







        }
    }
}
