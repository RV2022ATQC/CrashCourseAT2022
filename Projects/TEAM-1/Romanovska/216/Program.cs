using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _216
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Написати програму, яка виводить вміст масиву навпаки.
            // Приклад: масив 23 11 6 перетворюється в 6 23 11.

            int[] array = { 2, 4, 6, 8 };
            Array.Reverse(array);

            for (int i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
                Console.WriteLine("\t[{0}]:\t{1}", i, array.GetValue(i));
        }
    }
}
