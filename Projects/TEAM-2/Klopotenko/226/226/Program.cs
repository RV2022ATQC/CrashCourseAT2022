/* 226. Написати функцію, яка сортує масив  розмірністю 10 елементів за зростанням або за спаданням, в з
 алежності від третього параметра функції. Якщо він дорівнює 1, сортування йде за спаданням, якщо 0, то по зростанню. 
 Перші 2 параметра функції - це масив і його розмір, третій параметр за замовчуванням дорівнює 1. */



using System;

namespace _226
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Console.WriteLine("Enter the array: \n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter array[{i}]: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Entered array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            int length = -1;
            while (length < 1 || length > 10)
            {
                Console.Write("Enter length of new sorted array fom 1 to 10: ");
                length = int.Parse(Console.ReadLine());
                if  (length < 1 || length > 10)
                {
                    Console.WriteLine("Not correct input, try again");
                }
            }
            Console.Write("Enter 1 to sort from + to - or enter 0 to sort from - to +: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (a == 1 || a == 0)
            {
                ArraySorter(array, length, a);
            }
            else
            {
                Console.WriteLine("Default a = 1");
                Console.WriteLine();
                ArraySorter(array, length);
            }

            static void ArraySorter(int[] array, int length, int a = 1)
            {
                int[] arrayL = new int[length];
                for (int i = 0; i < length; i++)
                {
                    arrayL[i] = array[i];
                }
                if (a == 1)
                {
                    Array.Sort(arrayL);
                    Console.Write("Sorted array: ");
                    for (int i = length - 1; i >= 0 ; i--)
                    {
                        Console.Write($"{arrayL[i]} ");
                    }
                }
                else
                {
                    Array.Sort(arrayL);
                    Console.Write("Sorted array: ");
                    for (int i = 0; i < length; i++)
                    {
                        Console.Write(arrayL[i]);
                    }
                }
            }
        }
    }
}
