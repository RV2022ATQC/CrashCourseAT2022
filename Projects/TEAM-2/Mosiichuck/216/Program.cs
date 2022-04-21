using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _216
{
    class Program
    {
        //Написати програму, яка виводить вміст масиву навпаки.
        //Приклад: масив 23 11 6 42 перетворюється в 42 6 11 23.
        static void Main(string[] args)
        {
            int[] arr = new int[4];
            Console.WriteLine("Enter array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nYour array: ");
            printArr(arr);

            Console.WriteLine("Your array after revvers: ");
            Array.Reverse(arr);
            printArr(arr);
        }

        private static void printArr(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
