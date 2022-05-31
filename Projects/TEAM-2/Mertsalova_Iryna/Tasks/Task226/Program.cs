using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task226
{
    class Program
    {
        //Написати функцію, яка сортує масив  розмірністю 10 елементів за
        //зростанням або за спаданням, в залежності від третього параметра функції.
        //Якщо він дорівнює 1, сортування йде за спаданням, якщо 0, то по зростанню.
        //Перші 2 параметра функції - це масив і його розмір, третій параметр за замовчуванням дорівнює 1.

        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int choice = 0;
            do
            {

                Console.WriteLine("\n\t~ ~ ~ ~ ~ ~ ~ ~ ~ M E N U ~ ~ ~ ~ ~ ~ ~ ~ ~\n\n" +
                    "     - If you want array by increase, you must enter < 0 >\n" +
                    "     - If you want array by decrease, you must enter < 1 >\n\n" +
                    " --- For exit -> -1");
                Console.Write("\n Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        {
                            arr = new int[10] { 9, 8, 4, 7, 6, 1, 3, 5, 10, 2 };
                            Console.WriteLine(" Before --> ");
                            printArr(arr);
                            sort(arr, arr.Length, choice);
                            Console.WriteLine(" After --> ");
                            printArr(arr);
                            break;
                        }

                    case 1:
                        {
                            arr = new int[10] { 9, 8, 4, 7, 6, 1, 3, 5, 10, 2 };
                            Console.WriteLine(" Before --> ");
                            printArr(arr);
                            sort(arr, arr.Length, choice);
                            Console.WriteLine(" After --> ");
                            printArr(arr);
                            break;
                        }

                }
            } while (choice != -1);
            Console.WriteLine("  You're out! ");
        }

        private static void printArr(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write("  " + item);
            }
            Console.WriteLine();
        }

        private static void sort(int[] arr, int size, int param = 1)
        {
            bubbleSort(arr);
            if (param == 1)
            {
                Array.Reverse(arr);
            }
        }

        private static void bubbleSort(int[] arr)
        {
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }
    }
}
