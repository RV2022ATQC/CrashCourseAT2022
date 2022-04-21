/* 220.Написати overload методи Add які в залежності від параметрів або додають цифрові значення, 
або об'єднують введені тексти. Передбачити аргументи за замовчуванням і
використання глобальних змінних. */


using System;

namespace _220
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the first strring: ");
            string c = Console.ReadLine();
            Console.Write("Enter the second string: ");
            string d = Console.ReadLine();
            Console.WriteLine(); 
            Console.WriteLine(Add(a, b));
            Console.WriteLine(Add(d, c));
        }       

        private static int Add(int a = 2, int b = 3)
        {
            Console.Write("Using Add with int: ");
            return a + b;
        }

        private static string Add(string c = "aaa", string d = "bbb")
        {
            Console.Write("Using Add with string: ");
            return c + d;
        }
    }
}
