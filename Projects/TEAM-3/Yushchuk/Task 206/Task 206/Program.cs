using System;

namespace Task_206
{
    class Program{
        /* 
         ---------------------------------------------------------------------------------------
         Task 206: 1. Напишіть програму, яка перевіряє число, введене з клавіатури на парність.
         ---------------------------------------------------------------------------------------
        */
        static void Main(string[] args) {
            double a;

            Console.WriteLine("Enter number for check on even or odd: ");
            a = Convert.ToDouble(Console.ReadLine());

            if (a % 2 == 0) {
                Console.WriteLine("Number is even");
            }
            else{
                Console.WriteLine("Number is odd");
            }

        }
    }
}
