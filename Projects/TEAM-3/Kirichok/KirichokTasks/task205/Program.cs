using System;


namespace task205
{
    internal class Program
    { //5. Введіть три числа і виведіть на екран значення суми і добуток цих чисел.
        static void Main(string[] args)
        {
            float a,b,c,sum,dob;
            
            Console.WriteLine("Enter 3 numbers for suma:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            sum = a + b + c;
            Console.WriteLine($"Suma = {sum}");

            Console.WriteLine("Now better!");

            Console.WriteLine("Enter 3 numbers for dobutok:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine()); 

            dob = a * b * c;
            Console.WriteLine($"Dobutok = {dob}");
        }
    }
}
