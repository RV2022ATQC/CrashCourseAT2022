using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task226
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написати функцію, яка сортує масив  розмірністю 10 елементів за зростанням або за спаданням, в залежності від третього параметра функції. Якщо він дорівнює 1, сортування йде за спаданням, якщо 0, то по зростанню.
            //Перші 2 параметра функції - це масив і його розмір, третій параметр за замовчуванням дорівнює 1.
            var rand = new Random();
            const int size = 10;

            int[] a = new int[size];
            for (int i = 0; i < size; i++)
            {
                a[i] = rand.Next(-10, 10);
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine("\nEnter 1 to sort from bigger, 0 to sort from smaller: ");
            int sort = Convert.ToInt32(Console.ReadLine());
            Sort(a, size, sort);
        }
        static void Sort(int[] a, int size, int sort)
        {
            bool dif = true;
            int temp;
            if (sort == 0)
            {
                while (dif == true)
                {
                    dif = false;
                    for (int i = 0; i < size-1; i++)
                    {
                        if (a[i] > a[i + 1])
                        {
                            temp = a[i];
                            a[i] = a[i + 1];
                            a[i + 1] = temp;
                            dif = true;
                        }
                    }
                }
            }
            else if (sort == 1)
            {
                while (dif == true)
                {
                    dif = false;
                    for (int i = 0; i < size-1; i++)
                    {
                        if (a[i] < a[i + 1])
                        {
                            temp = a[i];
                            a[i] = a[i + 1];
                            a[i + 1] = temp;
                            dif = true;
                        }
                    }
                }
            }
            Console.WriteLine("------------");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{a[i]} ");
            }
        }
    }
}
