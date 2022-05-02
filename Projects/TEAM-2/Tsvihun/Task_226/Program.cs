// 226
// Написати функцію, яка сортує масив  розмірністю 10 елементів за зростанням або за спаданням, в залежності від третього параметра функції.
// Якщо він дорівнює 1, сортування йде за спаданням, якщо 0, то по зростанню. Перші 2 параметра функції - це масив і його розмір,
// третій параметр за замовчуванням дорівнює 1.
using System;

namespace Task_226
{
    internal class Arrays

    {
        static int[] defaultArray = { 7, 17, 19, 44, 15, -4, -3, 50, 12, 10 };
        static int arrayLength = defaultArray.Length;

        static int[] SortArray(int[] inputArray, int length, bool descendSort = true)
        {
            Array.Sort(inputArray);

            if (!descendSort)
            {
                return inputArray;
            }
            else
            {
                Array.Reverse(inputArray);
            }
            return inputArray;
        }

        static void ShowArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            ShowArray(defaultArray);

            // Sorting by Ascend
            SortArray(defaultArray, arrayLength, false);
            ShowArray(defaultArray);

            // Default sorting by Descend
            SortArray(defaultArray, arrayLength);
            ShowArray(defaultArray);
        }
    }
}
