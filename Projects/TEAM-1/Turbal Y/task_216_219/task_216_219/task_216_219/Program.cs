using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_216_219
{
    static class task
    {
        /*1. Написати програму, яка виводить вміст масиву навпаки.
Приклад: масив 23 11 6 перетворюється в 6 23 11.*/
        public static int Rewerse(int[] mas)
        {
            int i = 0, j = mas.Length - 1;
            while (i < j)
            {
                int temp = mas[i];
                mas[i] = mas[j];
                mas[j] = temp;
                i++;
                j--;
            }

            return 0;
        }
        /*Написати програму, яка знаходить в масиві значення, що повторюються два і більше разів, і показує їх на екран.*/
        public static int Repeat(int[] mas)
        {
            int  count = 0;
           
            for (int j = 0; j < mas.Length; j++) if (mas[j] == 0) count++;
            if (count >= 1) Console.WriteLine(0);
            //0 сиає маркером
            int[] a = new int[mas.Length];
            for (int i = 0; i < mas.Length ; i++)
                a[i] = mas[i];
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                    if (a[j] == a[i] && a[i] != 0) { count++; a[j] = 0; }
                if (count >= 1) Console.WriteLine(a[i]);
                count = 0;
            }
            return 0;
        }
        /* Написати програму, яка знаходить в масиві найменше непарне число і показує його на екран*/
        public static int MinNepar(int[] mas)
        {
            int min, i = 0;
            while (mas[i] % 2 == 0) i++;
            if (i == mas.Length - 1)
            { Console.WriteLine("Absent");
                return 0; }
            min = mas[i];
            for (int j = i + 1; j < mas.Length; j++)
                if (min > mas[j] && mas[j] % 2 != 0) min = mas[j];
             return min;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5] { 1, 2, 3, 4, 5 };

            /* task.Rewerse(a);
             for (int i = 0; i < a.Length; i++) Console.Write(a[i]);
             Console.ReadLine();*/
            int[] b = new int[7] { 2, 2, 3, 4, 5,3,3 };
            //task.Repeat(b);
            Console.WriteLine(task.MinNepar(b));
            Console.ReadLine();
        }
    }
}
