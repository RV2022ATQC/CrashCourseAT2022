/* 222. Написати перевантажені функції для знаходження коренів лінійного (a * x + b = 0) 
 і квадратного (a * x2 + b * x + c = 0) рівнянь. Зауваження: у функції передаються коефіцієнти рівнянь. */


using System;

namespace _222
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a, b and c to solve equations a != 0!): ");
            double a = 0;
            double b = 0;
            double c = 0;
            while (a == 0)
            {
            a = double.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("a = 0! Enter again!");
                    continue;
                }
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine($"Using EquationSolver to solve a * x + b = 0: ");
            Console.WriteLine(EquationSolver(a, b));
            Console.WriteLine();
            Console.WriteLine($"Using EquationSolver to solve a * x2 + b * x + c = 0: ");
            Console.WriteLine(EquationSolver(a, b, c));

        }
        private static string EquationSolver(double a, double b)
        {
            if (b == 0)
            {
                return $"The solution is 0";
            }
            double x = -b / a;
            return $"The solution is {x}"; 
        }
        private static string EquationSolver(double a, double b, double c)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    return $"The solution is 0";
                }
                double x1 = Math.Sqrt(-c / a);
                double x2 = -Math.Sqrt(-c / a);
                return $"The equation has 2 solutions x = {x1} or x = {x2}";
            }
            double D = b * b - 4 * a * c;
            if (D < 0)
            {
                return "This equation has no solutiouns because Discriminant < 0";
            }
            else if (D == 0)
            {
                double x = -b / 2*a;
                return $"The solution is {x}";
            }
            else
            {
                double x1 = (-b + Math.Sqrt(D)) / 2 * a;
                double x2 = (-b - Math.Sqrt(D)) / 2 * a;
                return $"The equation has 2 solutions x = {x1} or x = {x2}";
            }
        }
    }
}
