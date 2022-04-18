using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task218
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 6;
            int[] a = new int[n];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i+1} number: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                k = a[i];
                for (int j = 0; j < n; j++)
                {
                    if (a[j] == k && i != j)
                    {
                        Console.Write($"{a[j]}, ");
                    }
                }
            }
        }
    }
}
