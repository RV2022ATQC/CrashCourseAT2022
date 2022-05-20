using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _224
{
    class Program
    {
        //Дано масив випадкових чисел в діапазоні від -20 до +20. Необхідно знайти позиції крайніх негативних елементів
        //(самого лівого негативного елементу і самого правого негативного елементу) і впорядкувати елементи, що знаходяться між ними.
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = new int[15];
            int? positionf = null, positionl = null;
            Console.Write("Your array: ");
            for (int i = 0; i < 15; i++)
            {
                arr[i] = rnd.Next(-20, 20);
                if (positionf == null && arr[i] < 0)
                    positionf = i;
                else if (arr[i] < 0)
                    positionl = i;
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Array.Sort(arr, (int)positionf, (int)positionl);
            Console.Write("Your sorted array: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }
    }
}