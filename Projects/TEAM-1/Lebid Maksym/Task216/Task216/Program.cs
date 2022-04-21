using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task216
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[] a = new int[n];
            int k;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i+1} number: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int i = 0; i < n/2; i++)
            {
                k = a[i];
                a[i] = a[n - i - 1];
                a[n - i - 1] = k;
            }
            Console.WriteLine();
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write($"{a[i]}, ");
            }
            Console.WriteLine(a[n - 1]);
        }
    }
}
