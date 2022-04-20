using System;

// 5. Введіть три числа і виведіть на екран значення суми і добуток цих чисел.

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
