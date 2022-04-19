using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task219
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 6;
            int[] a = new int[n];
            int min;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1} number: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            min = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] < min && a[i]%2 != 0)
                {
                    min = a[i];
                }
            }
            if (min%2 == 0)
            {
                Console.WriteLine("There is no odd number");
            }
            else if (min%2 != 0)
            {
                Console.WriteLine($"{min} is the least odd number");
            }
        }
    }
}
