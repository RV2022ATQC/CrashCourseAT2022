using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _213
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Користувач вводить з клавіатури число, необхідно перевернути його (число) і вивести на екран.
            Примітка: Наприклад, користувач ввів число 12345. На екрані має з'явитися число навпаки - 54321.*/

            Console.WriteLine("Enter a No. to reverse");
            int num = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;
            while (num > 0)
            {
                int remainder = num % 10;
                reverse = (reverse * 10) + remainder;
                num /= 10;
            }
            Console.WriteLine("Reverse No. is {0}", reverse);
        }
    }
}
