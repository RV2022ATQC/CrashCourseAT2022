using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task224
{
    class Program
    {
        //Дано масив випадкових чисел в діапазоні від -20 до +20.
        //Необхідно знайти позиції крайніх негативних елементів
        //(самого лівого негативного елементу і самого правого негативного елементу)
        //і впорядкувати елементи, що знаходяться між ними.

        static void Main(string[] args)
        {
            int[] arr = new int[10] { 19, 4, -8, 0, -19, -17, -15, -8, 12, -15 };
            int minElem = 0, maxElem = 0;

            printArr(arr);
            findMinMax(arr, ref minElem, ref maxElem);

            Console.WriteLine(" Sorted array: ");
            Array.Sort(arr, (int)maxElem, (int)minElem);
            printArr(arr);
        }

        private static void findMinMax(int[] arr, ref int minElem, ref int maxElem)
        {
            int counter = 0;
            string index = null;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    counter++;
                    minElem = counter;
                    if (index == null)
                    {
                        maxElem = i;
                        index = " ";
                        continue;
                    }
                }
            }
        }

        private static void printArr(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write("  " + item);
            }
            Console.WriteLine();
        }
    }
}
