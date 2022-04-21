using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _214
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Користувач вводить з клавіатури число, необхідно показати на екран суму його цифр.
            Примітка: Наприклад, користувач ввів число 12345. 
            На екрані має з'явитися повідомлення про те, що сума цифр числа 15.*/

            int num;
            int sum = 0;
            int digit;
            Console.WriteLine("Enter a number:");
            num = Convert.ToInt32(Console.ReadLine());

            while (num > 0)
            {
                digit = num % 10;
                sum += digit;
                num /= 10;
            }
            Console.WriteLine($"Sum of the digits is = {sum}");

        }
    }
}
