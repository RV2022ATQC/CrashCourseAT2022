/*
 * 216.
 * Написати програму, яка виводить вміст масиву навпаки.
Приклад: масив 23 11 6 перетворюється в 6 23 11.
*/
using System;

namespace Task_216
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write($"Start array: ");

            int[] input_array = { 7, 17, 19, 44, 15 };

            foreach (int i in input_array)
            {
                Console.Write($"{i} ");
            }

            int middle_index = input_array.Length / 2;
            int temp_element;

            for (int i = 0; i < middle_index; i++)
            {
                temp_element = input_array[i];
                input_array[i] = input_array[input_array.Length - 1 - i];
                input_array[input_array.Length - 1 - i] = temp_element;
            }

            Console.Write($"\nReversed array: ");

            foreach (int i in input_array)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
