using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _206
{
    class Program
    {
        //Напишіть програму, яка перевіряє число, введене з клавіатури на парність
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter number: ");
            num = Int32.Parse(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine(num + "is even");
            else
                Console.WriteLine(num + "is odd");
        }
    }
}
