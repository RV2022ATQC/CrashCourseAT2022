using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tast_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = 0;
             a =   Convert.ToSingle(Console.ReadLine());

            Console.Write("b=");
            double b = 0;
            b = Convert.ToSingle(Console.ReadLine());

            Console.Write("c=");
            double c = 0;
            c = Convert.ToSingle(Console.ReadLine());

            double sum = a + b + c;
            Console.Write("a+b+c=");
            Console.WriteLine(sum);

            double mult = a * b * c;
            Console.Write("a*b*c=");
            Console.WriteLine(mult);

        }
    }
}
