using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task207
{
    internal class Program
    {
        static void Main(string[] args)
        {// Given a natural number a (a <100).
         // Write a program that displays the number of digits, including the sum of these digits

            Console.WriteLine("Enter your number. Number needs to be natural and from 1 to 99 (including 1 and 99)");
           
            int number = 0;
            number = (int)Convert.ToSingle(Console.ReadLine()); // вводимо число

            if ( number > 0 && number < 100)                    // перевірка чи число з потрібного діапазону
            {
                int FirstDigit = 0, SecondDigit = 0;
                FirstDigit = number % 10;                          // Находимо перше число

                SecondDigit = (number - number % 10) / 10;           // Находимо друге число

                int sum = 0, count = 0;

                sum = FirstDigit + SecondDigit;                    // Находимо сумму
                count = (int)Math.Floor(Math.Log10(number) + 1);   // Находимо кількість дігітів (StackOverflow)

                Console.WriteLine($"Sum of digits = " + sum);

                Console.WriteLine($"Count of digits = " + count);
            }
            else
                Console.WriteLine("Your number is not valid!");
        
        
        }
    }
}
