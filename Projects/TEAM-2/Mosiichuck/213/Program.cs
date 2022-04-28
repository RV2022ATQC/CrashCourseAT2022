using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _213
{
    class Program
    {
        //Користувач вводить з клавіатури число, необхідно перевернути його (число) і вивести на екран.
        //Примітка: Наприклад, користувач ввів число 12345. На екрані має з'явитися число навпаки - 54321
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter number: ");
            num = Int32.Parse(Console.ReadLine());
            Console.WriteLine(num.ToString().Reverse().ToArray());
        }
    }
}
