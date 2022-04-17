using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _209
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Розробити програму, яка виводить на екран горизонтальну лінію з символів. 
             Кількість символів, який використовувати символ, і яка буде лінія - вертикальна, або 
             горизонтальна - вказує користувач.*/

            Console.WriteLine("Enter quantity and type of symbol you want to see, also what kind of line:" +
                "vertical or horisontal:");
            Console.WriteLine("Enter number of symbols: ");
            int num_of_symbols = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter type of symbols: ");
            string type_of_symbol = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter type of line: ");
            string type_of_line = Convert.ToString(Console.ReadLine());
            int i;

            for(i=0; i<=num_of_symbols; i++)
            {
                if(type_of_line == "horizontal")
                {
                    Console.Write($" {type_of_symbol}");
                }
                else
                {
                    Console.WriteLine($"{type_of_symbol}");
                }
            }
        }
    }
}
