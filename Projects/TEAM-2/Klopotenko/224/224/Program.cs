/* Дано масив випадкових чисел в діапазоні від -20 до +20. Необхідно знайти 
 позиції крайніх негативних елементів 
 (самого лівого негативного елементу і самого правого негативного елементу)
 і впорядкувати елементи, що знаходяться між ними. */



using System;

namespace _224
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Console.WriteLine("Complete the array with 10 integer values from -20 to 20. Entrr \"Stop\" when you want finish: \n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter array[{i}]: ");
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] > 20 || array[i] < -20)
                {
                    Console.WriteLine("Enter values from -20 to 20!");
                    --i;
                    continue;
                }
            }
            Console.WriteLine();
            Console.Write("Entered array is: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("\n");
            int a = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    a++;
                }   
            }
            if (a < 2)
            {
                Array.Sort(array);
                Console.Write("Sorted array: ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
            }
            else
            {
                Array.Sort(array);
                int[] arrayCopy = array;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 0 && array[i+1] >= 0)
                    {
                        array[array.Length - 1] = array[i];
                        Array.Clear(array, i, 1);
                        for (int j = i; j < array.Length - 2; j++)
                        {
                            array[j] = arrayCopy[j+1];
                        }
                        break;
                    }
                }
                Console.Write("Sorted array: ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
            }
        }
    }
}
