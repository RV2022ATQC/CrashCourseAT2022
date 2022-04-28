using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _215
{
    class Program
    {
        //Написати програму, яка виводить на екран - наступну фігуру:
        //"********************                                                                                                                                                                                                       
        //*                  *                                                                                                                                                                                                        
        //*                  *                                                                                                                                                                                                        
        //*                  *                                                                                                                                                                                                        
        //*                  *                                                                                                                                                                                                        
        //********************                                                                                                                                                                                                        
        //ширина і висота фігури встановлюються користувачем з клавіатури.
        static void Main(string[] args)
        {
            int height = 0, weight = 0;
            Console.Write("Enter height: ");
            height = Int32.Parse(Console.ReadLine());
            Console.Write("Enter weight: ");
            weight = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < weight; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int i = 0; i < height-2; i++)
            {
                Console.Write("*");
                for (int j = 0; j < weight-2; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine();
            }

            for (int i = 0; i < weight; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
