using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task215
{
    internal class Program
    {
        static void Main(string[] args)
        { // Create programs that display the square figure.

            int height = 0, length = 0;
            Console.Write("Enter height: ");        // Вводимо висоту
            height = int.Parse(Console.ReadLine());

            Console.Write("Enter length: ");        // Вводимо ширину
            length = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Enjoy!\n");
            Console.ForegroundColor = ConsoleColor.Green;   // Робимо верхній контур зелений
            for (int l = 0; l < length; l++)
                Console.Write("*");
            Console.Write("\n");
            for (int h = 0; h < height - 2; h++)
            {
                Console.Write("*");
                if (length != 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;      // Робимо серединку червону
                    for (int l = 0; l < length - 2; l++)
                        Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.Green;    // Повертаємось до зеленого
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            if (height != 1)
                for (int l = 0; l < length; l++)         // Робимо верхній нижній контур 
                    Console.Write("*");

            Console.WriteLine("\n");
           
        }


    }
}
