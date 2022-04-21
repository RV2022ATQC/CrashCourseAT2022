// 218
// Написати програму, яка знаходить в масиві значення, що повторюються два і більше разів, і показує їх на екран.
using System;
using System.Linq;
using System.Collections.Generic;

namespace Task_218
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input_array = { 19, 6, 2, 0, 2, 4, 3, 3, 4, 20, 3, 7, 17, 6, 0, 5, 4, 44, 2, 8, 9 };
            List<int> repeated_numbers = new List<int>();
            var desired_array = repeated_numbers.Distinct();

            Console.WriteLine("Start array:");

            foreach (int i in input_array)
            {
                Console.Write($"{i} ");
            }

            // Find repeated numbers and add them to new list
            for (int i = 0; i < input_array.Length; i++)
            {
                for (int j = i+1; j < input_array.Length; j++)
                {
                    if (input_array[i] == input_array[j])
                    {
                        repeated_numbers.Add(input_array[i]);
                        break;
                    }
                }
            }             

            Console.WriteLine($"\nRepeated numbers:");
            foreach (int i in desired_array)
            {
                Console.Write($"{i} ");
            }            
        }
    }
}
