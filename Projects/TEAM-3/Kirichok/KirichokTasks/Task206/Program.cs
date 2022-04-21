using System;
// 206. Напишіть програму, яка перевіряє число, введене з клавіатури на парність.


namespace Task206
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Введiть число:");
           
            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("число парне");
            }
            
            else
            {
                Console.WriteLine("число не парне");
            }
            Console.ReadKey();
        }
    }
}
