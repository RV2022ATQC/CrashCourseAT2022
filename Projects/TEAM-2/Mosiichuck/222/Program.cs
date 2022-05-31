using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _222
{
    class Program
    {
        //Написати перевантажені функції для знаходження коренів лінійного (a * x + b = 0)
        //і квадратного (a * x2 + b * x + c = 0) рівнянь. Зауваження: у функції передаються коефіцієнти рівнянь
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Enter a: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            b = Int32.Parse(Console.ReadLine());
            FindingRoots(a, b);
            Console.Write("Enter a: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            c = Int32.Parse(Console.ReadLine());
            FindingRoots(a, b, c);
        }

        static void FindingRoots(int a, int b)
        {
            if (a != 0)
                Console.WriteLine("x = " + ((double)-b / a));
            else
                Console.WriteLine("Can't divide by 0");
        }

        static void FindingRoots(int a, int b, int c)
        {
            if (a == 0)
                FindingRoots(b, c);
            else
            {
                var discriminant = b * b - 4 * a * c;
                if (discriminant >= 0)
                {
                    var x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    var x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine("x1 = " + x1 + ", x2 = " + x2);
                }
                else
                {
                    Console.WriteLine("No roots");
                }
            }
        }
    }
}