using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task222
{
    class Program
    {
        //Написати перевантажені функції для знаходження коренів лінійного (num1 * x + num2 = 0) і квадратного (num1 * x2 + num2 * x + num3 = 0) рівнянь.
        //Зауваження: у функції передаються коефіцієнти рівнянь.
        static void Main(string[] args)
        {
            double[] a;
            Console.WriteLine($"Solution of a linear equation {0}*x+{1}=0 x={2}\n", 2, 3, calc(2, 3));
            Console.WriteLine($"Solution of a square equationя {0}*x*x+{1}*x+{2}=0", 1, 8, 12);
            a = calc(1, 8, 12);
            print(a);
            Console.WriteLine("Рішення квадратного рівняння {0}*x*x+{1}*x+{2}=0", 1, 5, 20);
            a = calc(1, 5, 20);
            print(a);
        }


        public static double calc(double num1, double num2)
        {
            return (-num2) / num1; 
        }

        public static double[] calc(double num1, double num2, double num3)
        {
            double[] res = new double[3];
            res[0] = 0; //признак того що корнів немає

            double d = Math.Pow(num2, 2) - 4 * num1 * num3;
            if (d < 0)
            {
                return res;
            }
            else
            {
                res[0] = 2;
                res[1] = ((-num2) + Math.Sqrt(d)) / (2 * num1);
                res[2] = ((-num2) - Math.Sqrt(d)) / (2 * num1);
                return res;
            }
        }

        public static void print(double[] arr)
        {
            if (arr[0] == 0)
            {
                Console.WriteLine("Discriminants are less than zero, no roots");
            }
            else
            {
                Console.WriteLine("x1={0}; x2={1}", arr[1], arr[2]);
            }
        }
    }
}
