// 222
// Написати перевантажені функції для знаходження коренів лінійного (a * x + b = 0) і квадратного (a * x2 + b * x + c = 0) рівнянь.
// Зауваження: у функції передаються коефіцієнти рівнянь.
using System;

namespace Task_222
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Program program1 = new Program();

            program1.equation(0, 7);
            program1.equation(12, 4);
            program1.equation(-4, 12);

            program1.equation(0, 6, 9);
            program1.equation(2, 12, 4);
            program1.equation(1, 1, 0);
            program1.equation(1, 1, 1);           

        }

        // Linear equation
        void equation (int a , int b)
        {
            if (a != 0)
            {
                var x = (double)-b / a;
                Console.WriteLine($"x = {x}");
            }
            else
            {
                Console.WriteLine($"Division by zero. a must be <> 0.");
            }
        }

        // Quadratic equation
        void equation (int a, int b, int c)
        {
            // If a=0 go to linear equation
            if (a == 0) equation(b, c);
            else
            {
                var discriminant = b * b - 4 * a * c;
                if (discriminant >= 0)
                {
                    var x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    var x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine($"x1 = {x1} x2 = {x2}");
                }
                else
                {
                    Console.WriteLine("Incorrect input values !");
                }
            }
        }
        
    }
}
