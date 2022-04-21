using System;

namespace Task_202{
    class Program{
        /*
         -------------------------------------------------------
         Task 202 Напишіть програму, яка переводить гривні в $, Є.
         -------------------------------------------------------
         */
        static void Main(string[] args){

            Console.WriteLine("Enter how to convert from Grivnya to $,euro: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Just now $: 29.9, euro: 32.5");

            double c = a / 29.9;
            double b = a / 32.5;

            Console.WriteLine("Your $: " + c);
            Console.WriteLine("Your euro: " + b);







        }
    }
}
