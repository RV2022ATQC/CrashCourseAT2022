using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226
{
    class Program
    {
        //Написати функцію, яка сортує масив  розмірністю 10 елементів за зростанням або за спаданням, в залежності від третього параметра функції.
        //Якщо він дорівнює 1, сортування йде за спаданням, якщо 0, то по зростанню. Перші 2 параметра функції - це масив і його розмір,
        //третій параметр за замовчуванням дорівнює 1.
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = new int[10];
            Console.Write("Your array: ");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rnd.Next(-20, 20);
                Console.Write(arr[i] + " ");
            }
            Console.Write("\nCount of elements: ");
            int count = Int32.Parse(Console.ReadLine());
            Console.WriteLine("1 - sort by descending\n0 - sort by increasing");
            int flag = Int32.Parse(Console.ReadLine());
            SortArray(arr, count, flag);
        }

        static void SortArray(int[] arr, int lenght, int flag = 1)
        {
            if (flag == 1)
            {
                Array.Sort(arr, 0, lenght);
                Array.Reverse(arr, 0, lenght);

            }
            else if (flag == 0)
            {
                Array.Sort(arr, 0, lenght);
            }
            Console.Write("Sorted array: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}