using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _205
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5. Введіть три числа і виведіть на екран значення суми і добуток цих чисел.

            Console.Write("First number: ");
            string first = Console.ReadLine();
            
            Console.Write("Second number: ");
            string second= Console.ReadLine();

            Console.Write("Third number: ");
            string third= Console.ReadLine();

            float sum = Int32.Parse(first) + Int32.Parse(second) + Int32.Parse(third);

            float dob = Int32.Parse(first) * Int32.Parse(second) * Int32.Parse(third);

            Console.Write("Suma: " + sum);
            Console.WriteLine("\nDobutok: " + dob);


        }
    }
}
