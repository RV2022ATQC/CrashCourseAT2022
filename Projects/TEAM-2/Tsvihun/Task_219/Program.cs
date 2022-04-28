//219.
//Написати програму, яка знаходить в масиві найменше непарне число і показує його на екран.
using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_219
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input_array = { 19, 6, 22, 9, 3, 3, 4, 20, 3, 7, 17, 6, 0, 5, 19, 44, 2, 8, 15 };
            List<int> output = new List<int>();

            // Find only odd numbers and copy them to new list
            for (int i = 0; i < input_array.Length; i++)
            {
                if ((input_array[i] % 2) != 0)
                {
                    output.Add(input_array[i]);
                }
            }

            // Show full array
            Console.Write($"Array:\t");
            foreach (int element in input_array)
            {
                Console.Write($"{element} ");
            }

            // Show desired number
            Console.WriteLine($"\nMin odd number: {output.Min()}");


        }
    }
}
