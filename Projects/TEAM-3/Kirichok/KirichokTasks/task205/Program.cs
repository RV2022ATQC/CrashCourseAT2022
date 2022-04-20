using System;

namespace task205
{
    internal class Program
    { //5. Введіть три числа і виведіть на екран значення суми і добуток цих чисел.
        static void Main(string[] args)
        {
            int a,b,c,sum,product;
            
            Console.WriteLine("Enter 1 number for sum & product:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2 number for sum & product:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3 number for sum & product:");
            c = Convert.ToInt32(Console.ReadLine());

            sum = a + b + c;
            product = a * b * c;
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Product = {product}");
        }
    }
}
