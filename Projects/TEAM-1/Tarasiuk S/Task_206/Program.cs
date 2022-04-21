using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_206
{
    internal class Program
    {
        static void Main(string[] args)
        {// Write program that checks the number entered from the keyboard for parity. 
           
            Console.WriteLine("Enter number for checking");
            
            int number = 0;
            number = (int)Convert.ToSingle(Console.ReadLine());

            if (number % 2 == 0)      // Перевірка на кратність двом
                Console.WriteLine("Your Number is Even");
            else
                Console.WriteLine("Your Number is ODD");

        }
    }
}
