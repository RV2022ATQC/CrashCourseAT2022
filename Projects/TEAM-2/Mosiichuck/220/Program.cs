using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220
{
    class Program
    {
        //Написати overload методи Add які в залежності від параметрів або додають цифрові значення, або об'єднують введені тексти.
        //Передбачити аргументи за замовчуванням і використання статичних полів\методів
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the first text: ");
            string c = Console.ReadLine();
            Console.Write("Enter the second text: ");
            string d = Console.ReadLine();

            Console.WriteLine("Methods with parameters");
            Console.WriteLine(Add(a, b));
            Console.WriteLine(Add(c, d));
        }

        private static int Add(int a = 1, int b = 2)
        {
            Console.Write("Method Add with int: ");
            return a + b;
        }

        private static string Add(string c = "a", string d = "b")
        {
            Console.Write("Method Add with string: ");
            return c + d;
        }
    }
}