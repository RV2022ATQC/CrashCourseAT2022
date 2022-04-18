using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _218
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Написати програму, яка знаходить в масиві значення, що повторюються два і більше разів,
            // і показує їх на екран.

            int[] arr = { 2, 4, 8, 10, 4, 8, 5, 12, 2, 30, 77, 14, 8 };

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
            }

        }
    }
}
