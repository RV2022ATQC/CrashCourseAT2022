using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _219
{
    class Program
    {
        //Написати програму, яка знаходить в масиві найменше непарне число і показує його на екран
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            int min = 100000;
            Console.WriteLine("Enter array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
                if (arr[i] % 2 != 0 && min > arr[i])
                    min = arr[i];
            }

            Console.WriteLine("\nYour array: ");
            printArr(arr);

            Console.WriteLine("Minimum odd number in array is " + min);
        }

        private static void printArr(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
