using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _215
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Написати програму, яка виводить на екран - наступну фігуру:
               "*********************                                                                                                                                                                                                        
                *                   *                                                                                                                                                                                                        
                *                   *                                                                                                                                                                                                        
                *                   *                                                                                                                                                                                                        
                *                   *                                                                                                                                                                                                        
                *********************                                                                                                                                                                                                        
               ширина і висота фігури встановлюються користувачем з клавіатури.*/


            Console.WriteLine("Please, enter width and height of the figure to display:");

            Console.WriteLine("Please, enter a desired symbol: ");
            string symbol = Console.ReadLine();
            Console.WriteLine("Please, enter width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter height: ");
            int height = Convert.ToInt32(Console.ReadLine());


            for (int row = 1; row <= height; row++)
            {
                for (int column = 1; column <= width; column++)
                {
                    if ((row == 1) || (row == height))
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        if ((column == 1) || (column == width))
                        {
                            Console.Write(symbol);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}