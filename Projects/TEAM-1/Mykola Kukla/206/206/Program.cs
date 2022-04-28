using System;

// 206. Напишіть програму, яка перевіряє число, введене з клавіатури на парність.

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            a = int.Parse(Console.ReadLine());

            int temp = a % 2;

            bool result = temp == 0;

            if (result)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }

        }
    }
}
