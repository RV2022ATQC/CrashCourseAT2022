using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _218
{
    class Program
    {
        //Написати програму, яка знаходить в масиві значення, що повторюються два і більше разів, і показує їх на екран
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            Console.WriteLine("Enter array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            List<int> repeatingNumbers = new List<int>();

            Console.WriteLine("\nYour array: ");
            printArr(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        repeatingNumbers.Add(arr[i]);
                        break;
                    }
                }
            }

            Console.WriteLine($"\nRepeated numbers:");
            foreach (int item in repeatingNumbers.Distinct())
            {
                Console.Write(item + " ");
            }
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
