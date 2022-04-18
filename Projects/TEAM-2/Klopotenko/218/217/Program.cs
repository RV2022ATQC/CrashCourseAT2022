/* 218. Написати програму, яка знаходить в масиві значення, 
 що повторюються два і більше разів, і показує їх на екран. */


using System;

namespace _218
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter array[" + i + "]: ");
                array[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Entered array is:");
            foreach (var item in array)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine("\n");
            Console.Write("Repeated numbers are: ");
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        Console.Write(array[i] + " ");
                    }
                }
            }
        }
           
    }
}
