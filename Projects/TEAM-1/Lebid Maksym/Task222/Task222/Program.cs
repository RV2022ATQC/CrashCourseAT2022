using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написати перевантажені функції для знаходження коренів лінійного (a * x + b = 0) і квадратного (a * x2 + b * x + c = 0) рівнянь.
            //Зауваження: у функції передаються коефіцієнти рівнянь.
            float a, b, c;
            int t;
            Console.WriteLine("1 for linear, 2 for quadratic: ");
            t = Convert.ToInt32(Console.ReadLine());
            if (t == 1)
            {
                Console.WriteLine("Enter a: ");
                a = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Enter b: ");
                b = Convert.ToSingle(Console.ReadLine());
                Answer(a, b);
            }
            else if (t == 2)
            {
                Console.WriteLine("Enter a: ");
                a = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Enter b: ");
                b = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Enter c: ");
                c = Convert.ToSingle(Console.ReadLine());
                Answer(a, b, c);
            }
        }
        static void Answer(float a, float b)
        {
            if (a != 0)
            {
                float x = -b / a;
                Console.WriteLine($"Answer: {x}");
            }
            else Console.WriteLine("a cant be 0");
            
        }
        static void Answer(float a, float b, float c)
        {
            double d = b * b - 4 * a * c;
            double x1, x2;
            if (d < 0)
            {
                Console.WriteLine("No answer");
            }
            else if (d == 0)
            {
                x1 = -b / 2*a;
                Console.WriteLine($"Answer: {x1}");
            }
            else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / 2;
                x2 = (-b - Math.Sqrt(d)) / 2;
                Console.WriteLine($"Answer: {x1}, {x2}");
            }
        }
    }
}
