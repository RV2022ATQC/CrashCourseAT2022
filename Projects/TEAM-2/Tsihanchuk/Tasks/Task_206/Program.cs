using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _206
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Vvedit chislo: ");
            x = Console.Read();



            if(x % 2==0)
            {
                Console.WriteLine("This is pair number!");
            }
            else
                Console.WriteLine("This is unpair number!");

        }
    }
}
