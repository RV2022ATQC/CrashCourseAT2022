using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_220_226
{
    class tasks
    {
        public DateTime currentDay;
        public tasks()
        {
            currentDay = DateTime.Today;
        }
        /*Написати overload методи Add які в залежності від параметрів або додають цифрові значення,
         або об'єднують введені тексти. Передбачити аргументи за замовчуванням і використання глобальних змінних.*/
        public int Add(int a, int b = 0)
        {
            return a + b;
        }
        public string Add(string s1, string s2 = "!")
        {
            return s1 + s2;
        }
        /*Написати overload методи RemoveFromString, які приймають текст і видаляють з нього або
         певний набір символів, або символ\символи за порядковим номером в тексті. 
         Реалізувати використання аргументів за замовчуванням та глобальних\локальних змінних*/
        public string RemoveFromString(string s, int num)
        {
            return s.Remove(num, 1);
        }
        public string RemoveFromString(string s, int num, int count)
        {
            return s.Remove(num, count);
        }
        public string RemoveFromString(string s, string removeSet)
        {
            int i;
            foreach (var ch in removeSet)
            {
                i = 0;
                while (i < s.Length)
                {
                    if (ch == s[i]) s = s.Remove(i, 1);
                    else i++;
                }
            }
            return s;
        }
        /*Написати перевантажені функції для знаходження коренів лінійного (a * x + b = 0) і квадратного 
         * (a * x2 + b * x + c = 0) рівнянь.
         Зауваження: у функції передаються коефіцієнти рівнянь*/
        public float solve(float a, float b)
        {
            if (a != 0) return -b / a;
            else return 0;
        }
        public double[] solve(float a, float b, float c)
        {
            double[] rezult = new double[3];
            if (a == 0) rezult[2] = 2; //рівняння не квадратне
            else
            {
                double D = b * b - 4 * a * c;
                if (D >= 0)
                {
                    rezult[0] = (-b + Math.Sqrt(D)) / (2 * a);
                    rezult[1] = (-b - Math.Sqrt(D)) / (2 * a);
                    rezult[2] = 0;//Ok
                }
                else rezult[2] = 1;//рівняння має комплексні корені
            }
            return rezult;

        }
        /*Дано масив випадкових чисел в діапазоні від -20 до +20. 
         Необхідно знайти позиції крайніх негативних елементів (самого лівого негативного елементу і 
         самого правого негативного елементу) і впорядкувати елементи, що знаходяться між ними.*/
        public int sort(int[] b)
        {
            int left = 0, right = b.Length - 1;
            if (left >= right) return 0;
            while (left < right && (b[left] >= 0 || b[right] >= 0))
            {
                if (b[left] >= 0) left++;
                if (b[right] >= 0) right--;
            }
            if (left >= right) return 0;//некоректний масив
            else
            {
                if (right - left <= 2) return 1;//нема що сортувати
                left++; right--;
                for (int i = left; i < right; i++)
                    for (int j = right; j > i; j--)
                        if (b[j] < b[j - 1]) { int tmp = b[j]; b[j] = b[j - 1]; b[j - 1] = tmp; }
                return 2;//good
                         //return left;
            }
        }
        /*Написати функцію, яка сортує масив  розмірністю 10 елементів за зростанням або за спаданням, в залежності від третього параметра функції. Якщо він дорівнює 1, сортування йде за спаданням, якщо 0, то по зростанню. 
         Перші 2 параметра функції - це масив і його розмір, третій параметр за замовчуванням дорівнює 1.*/
        public void sort(int[] b, int size, int flag = 1)
        {
            int left = 0, right = b.Length - 1;


            for (int i = left; i < right; i++)
                for (int j = right; j > i; j--)
                    if (flag == 1)
                    {
                        if (b[j] < b[j - 1])
                        { int tmp = b[j]; b[j] = b[j - 1]; b[j - 1] = tmp; }
                    }
                    else
                    {
                        if (b[j] > b[j - 1])
                        { int tmp = b[j]; b[j] = b[j - 1]; b[j - 1] = tmp; }
                    }




        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                tasks t1 = new tasks();
                // Console.WriteLine(t1.Add("Hello"));
                // Console.WriteLine(t1.RemoveFromString("Hello",2,3));
                // Console.WriteLine(t1.RemoveFromString("Hello", "Hl"));
                // Console.ReadLine();
                int[] a = new int[11] { -1, 2, 3, -4, 5, 6, -7, 8, -9, 10, -11 };
                for (int i = 0; i < a.Length; i++) Console.Write(a[i] + " ");
                t1.sort(a, 11, 0);
                Console.WriteLine();
                for (int i = 0; i < a.Length; i++) Console.Write(a[i] + " ");
                Console.ReadLine();
            }
        }
    
}
