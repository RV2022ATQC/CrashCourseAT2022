using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task209
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount;
            bool vertical;
            string s;
            Console.WriteLine("Enter amount of symbols: ");
            amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter true for vertical, false for horizontal: ");
            vertical = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter symbol: ");
            s = Console.ReadLine();
            if (vertical == false)
            {
                for (int i = 0; i < amount; i++)
                {
                    Console.Write(s);
                }
                Console.Write("\n");
            }
            else if (vertical == true)
            {
                for(int i = 0; i < amount; i++)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
