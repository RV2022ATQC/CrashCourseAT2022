using System;

namespace Task_204{
    class Program
    {
        /* Task 204. Напишіть програму, яка обчислює квадрат будь-якого, введеного числа.*/
        static void Main(string[] args){
            Console.WriteLine("Enter number: ");
            double  a = Convert.ToDouble(Console.ReadLine());

            var b = a * a;

            Console.WriteLine("Number " + a + "^2 = " + b );
        }
    }
}
