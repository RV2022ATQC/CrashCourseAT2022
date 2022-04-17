// 4. Напишіть програму, яка обчислює квадрат будь-якого, введеного числа.
using System;


namespace Task204
{
    internal class Program
    {
            
        static void Main(string[] args)
        {
            float a;
            Console.WriteLine("Enter please:");
            a = Convert.ToInt32(Console.ReadLine());
           
            a = a * a;
            Console.WriteLine($"square is = {a}");

        }
    }
}
