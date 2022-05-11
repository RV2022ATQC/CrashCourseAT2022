using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _207
{
    //2. Дано натуральне число а (a <100). Напишіть програму, що виводить на екран кількість цифр в цьому числі і суму цих цифр
    public class Program
    {
        static void Main(string[] args)
        {
            int number;
            
            System.Console.Write("Enter a number in array of (0<a<100) ");
            number=Int32.Parse( System.Console.ReadLine());
            {
                if(number>=100||number<0)
                {
                    Console.WriteLine("Incorrect value");
                }
                else 
                    {
                    if(number>9)
                    {
                        Console.WriteLine("We have two number");
                        Console.WriteLine("Sum of number is:" + ((number / 10) + (number % 10)));
                    }else
                        {
                        Console.WriteLine("We have one number");
                        Console.WriteLine("Sum of number is:" + number);
                        }

                    }
            }
            
        }
    }
}
