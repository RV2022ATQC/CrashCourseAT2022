using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task210
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            Console.WriteLine("Enter number");
            string a = Convert.ToString(Console.ReadLine());
            for(int i = 0; i < 10; i++)
            {
                if (a.Contains($"{i}"))
                {
                    k++;
                }
            }
            Console.WriteLine($"Number contains {k} symbols");
        }
    }
}
