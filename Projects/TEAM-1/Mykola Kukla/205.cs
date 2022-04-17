







// 5. Введіть три числа і виведіть на екран значення суми і добуток цих чисел.

namespace Tasks
{
    class Program
    {

        static void Main(string[] args)
        {
            string w;

            int  a, b, с;

            Console.WriteLine("Please enter the first digit ");

            w = Console.ReadLine();

            a = Convert.ToInt32(w);

            Console.WriteLine("Please enter the second digit ");

            w = Console.ReadLine();

            b = Convert.ToInt32(w);

            Console.WriteLine("Please enter the third digit ");

           w = Console.ReadLine();

            с = Convert.ToInt32(w);

            int result = (a * b * с);

            Console.WriteLine("The product of three numbers = " + result);




        }

    }
}
