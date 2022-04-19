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
        {
            Console.WriteLine("Enter heigth: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            int w = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < w; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
            for(int i = 0; i < h-2; i++)
            {
                Console.Write("*");
                for (int j = 0; j < w-2; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*\n");
            }
            for (int i = 0; i < w; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
}
