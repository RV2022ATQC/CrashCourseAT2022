using System;

namespace Task_201{
    class Program{
        /* 
        --------------------------------------------------------------------------
         Task 201 Напишіть програму, яка обчислює середнє арифметичне двох чисел. 
        --------------------------------------------------------------------------
         */
        static void Main(string[] args){

            Console.WriteLine("First num: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second num: ");
            int b = Convert.ToInt32(Console.ReadLine());

            double sum = (a + b) / 2;

            Console.WriteLine($"Arithmetic mean: {sum}");


        }
    }
}
