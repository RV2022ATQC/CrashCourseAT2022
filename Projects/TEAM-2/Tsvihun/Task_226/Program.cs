// 226
// Написати функцію, яка сортує масив  розмірністю 10 елементів за зростанням або за спаданням, в залежності від третього параметра функції.
// Якщо він дорівнює 1, сортування йде за спаданням, якщо 0, то по зростанню. Перші 2 параметра функції - це масив і його розмір,
// третій параметр за замовчуванням дорівнює 1.
using System;

namespace Task_226
{
    internal class Arrays

    {
        static int[] default_array = { 7, 17, 19, 44, 15, -4, -3, 50, 12, 10 };
        static int array_length = default_array.Length; 

        static int[] SortArray (int[] input_array, int length, int sort_type = 1)
        {
            Array.Sort(input_array);

            if (sort_type == 0)
            {
                return input_array;                
            }
            if (sort_type == 1)
            {
                Array.Reverse(input_array);
            }
            return input_array;
        }

        static void ShowArray (int[] array)
        {
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            ShowArray(default_array);
                       
            // Sorting by Ascend
            SortArray(default_array, array_length, 0);
            ShowArray(default_array);

            // Default sorting by Descend
            SortArray(default_array, array_length);
            ShowArray(default_array);
        }
    }
}
