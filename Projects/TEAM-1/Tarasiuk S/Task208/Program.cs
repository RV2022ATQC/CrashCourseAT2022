using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task208
{
    internal class Program
    {
        static void Main(string[] args)
        {//Create program to convert cm into inches OR inches into cm DEPENDING user choice
            Console.WriteLine("Enter you number");
            double number = 0;
            number = Convert.ToSingle(Console.ReadLine());    // вводимо число

            Console.WriteLine("Chose \n" +
                "U want conver cm into inches INPUT 1 \n" +
                "U want conver cm into inches INPUT 2");   // вибираємо що з ним робити        
            var choise = 0;

            choise = (int)Convert.ToSingle(Console.ReadLine());

            double converted = 0;     

            if (choise == 1)       
            {
                converted = number * 2.54;
                Console.WriteLine($"{converted} inches");  
            }
            else if (choise == 2)
            {
                converted = number / 2.54;
                Console.WriteLine($"{converted} cm");
            }

            else
                Console.WriteLine("Error your choice is not valid. Please try again and read all condition :)");
        }
    }
}
