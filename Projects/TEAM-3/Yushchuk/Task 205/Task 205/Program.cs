using System;

namespace Task_205{
    class Program{
        /* 
         --------------------------------------------------------------------------------------
        Task 205: 5. Введіть три числа і виведіть на екран значення суми і добуток цих чисел.
         --------------------------------------------------------------------------------------
         */
        static void Main(string[] args){
            double a, b, c,sum, mult;

            Console.WriteLine("Enter 3 number: ");

            Console.WriteLine("a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("c: ");
            c = Convert.ToDouble(Console.ReadLine());

            sum = a + b + c;
            mult = a * b * c;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Multipiclation: " + mult);


        }
    }
}
