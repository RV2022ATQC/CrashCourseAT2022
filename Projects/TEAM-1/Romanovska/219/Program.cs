using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _219
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написати програму, яка знаходить в масиві найменше непарне число і показує його на екран

            int[] arr = { 20, 50, 88, 45, 36, 15, 24, 11, 8, 66 };

            var index = 0;
            while (arr[index] % 2 == 0) index++; 
            var min = arr[index++]; 
            while (index < arr.Length)
            {
                if (arr[index] % 2 == 1)
                {
                    if (arr[index] < min) min = arr[index];
                }
                index++;  
            }
            Console.WriteLine($"The minimum odd number is: {min}");
        }
    }
}
