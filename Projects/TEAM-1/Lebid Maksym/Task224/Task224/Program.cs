using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task224
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дано масив випадкових чисел в діапазоні від -20 до +20.
            //Необхідно знайти позиції крайніх негативних елементів (самого лівого негативного елементу і самого правого негативного елементу) і впорядкувати елементи, що знаходяться між ними.
            var rand = new Random();
            int l = -1, r = -1, i = 0, temp;
            bool dif = true;

            const int n = 10;
            int[] a = new int[n];

            for (int j = 0; j < n; j++)
            {
                a[j] = rand.Next(-20, 20);
                Console.Write($"{a[j]} ");
            }

            while (l == -1 && i < n)
            {
                if (a[i] < 0)
                {
                    l = i;
                }
                i++;
            }

            i = 9;
            while (r == -1 && i > -1)
            {
                if (a[i] < 0)
                {
                    r = i;
                }
                i--;
            }

            while (dif == true)
            {
                dif = false;
                for (i = l + 1; i < r-1; i++)
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
            Console.WriteLine("\n-----------");
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{a[j]} ");
            }

        }
    }
}
