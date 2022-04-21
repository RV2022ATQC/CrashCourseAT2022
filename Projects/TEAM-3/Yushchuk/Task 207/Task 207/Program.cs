using System;

namespace Task_207{
    class Program{
        /* 
         ---------------------------------------------------------------------------------------------------------------------------
         Task 207 2. Дано натуральне число а (a < 100). Напишіть програму, що виводить на екран кількість цифр в цьому числі і суму цих цифр
         ---------------------------------------------------------------------------------------------------------------------------
        */
        static void Main(string[] args){
            int a, sum;

            Console.WriteLine("Enter number(a < 100): ");
            a = Convert.ToInt32(Console.ReadLine());

                if (a < 10){
                    Console.WriteLine("Number of single digits" + a);
                    
                }
                else if (a > 100){
                    Console.WriteLine("Less a < 100");
                }
                else if (a > 10){

                    sum = (a / 10) + (a % 10);

                    Console.WriteLine("Sum of two digits: " + sum);
                    
                }
            

            






        }
    }
}
