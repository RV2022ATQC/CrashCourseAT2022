/* 216. Написати програму, яка виводить вміст масиву навпаки.
Приклад: масив 23 11 6 перетворюється в 6 11 23. */




using System;

namespace _216
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3] { 23, 11, 6 };
            int length = array.Length;
            Console.Write("The contents of the array on the contrary: ");
            for (int i = --length; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
            
        }
    }
}
