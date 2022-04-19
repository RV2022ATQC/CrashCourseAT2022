/* 219. Написати програму, яка знаходить в масиві 
  найменше непарне число і показує його на екран. */



using System;

namespace _219
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter array[" + i + "]: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Entered array is: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            int a = array[0];
            if (a % 2 != 1 && a % 2 != -1)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] % 2 == 1 || array[i] % 2 == -1)
                    {
                        a = array[i];
                        break;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < a && array[i] % 2 == 1 || array[i] % 2 == -1)
                {
                    a = array[i];
                }
            }
            if (a % 2 == 1 || a % 2 == -1)
            {
                 Console.WriteLine($"The least odd number {a}");

            }
            else
            {
                 Console.WriteLine("There no any odd numbers in this array");
            } 
        }
    }
}
