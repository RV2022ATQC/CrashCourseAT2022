using System;

namespace EX_201___205
{
    class Program
    {
        
        static void EX_201()// 1. Напишіть програму, яка обчислює середнє арифметичне двох чисел.
        { 
            float number1=0, number2=0;

            Console.WriteLine("Enter first number: ");
            number1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            number2 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nAvarage from "+number1+" and "+number2+" = "+(number1 + number2)/2);

        }

        
        static void EX_202()// 2.Напишіть програму, яка переводить гривні в $, Є.
        {
            float amountInp=0;
            Console.WriteLine("Enter amount in UAH : ");
            amountInp = float.Parse(Console.ReadLine());

            float koofEUR=1/32.25f, koofUSD=1/29.59f;

            Console.WriteLine("\n" + amountInp + " UAH = " + amountInp * koofUSD + " USD");
            Console.WriteLine("\n" + amountInp + " UAH = " + amountInp * koofEUR + " EUR");

        }

        
        static void EX_203()//3. Виведіть на екран наступний текст: To be or not to be \ Shakespeare \"
        {
            Console.WriteLine("\n\tTo be or not to be \n\n\t \\ Shakespeare \\");
        }

        
        static void EX_204()//4. Напишіть програму, яка обчислює квадрат будь-якого, введеного числа.
        {
            double number = 0;

            Console.WriteLine("Enter number :");
            number = double.Parse(Console.ReadLine());
            double rez = Math.Pow(number, 2);

            Console.WriteLine("(" + number + ")^2 = " + rez);
        }

        
        static void EX_205()//5. Введіть три числа і виведіть на екран значення суми і добуток цих чисел.
        {
            float number1 = 0, number2 = 0, number3 = 0;
            float sum = 0, product = 1;

            Console.WriteLine("Enter first number: ");
            number1 = float.Parse(Console.ReadLine());
            sum += number1;
            product *= number1;
            Console.WriteLine("Enter second number: ");
            number2 = float.Parse(Console.ReadLine());
            sum += number2;
            product *= number2;
            Console.WriteLine("Enter third number: ");
            number3 = float.Parse(Console.ReadLine());
            sum += number3;
            product *= number3;



            Console.WriteLine("\n" + number1 + " + " + number2 + " + " + number3 + " = " + sum);
            Console.WriteLine("\n"+number1 + " * " + number2 + " * " + number3 + " = " + product);
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Enter:\n\n1  -  Ex 201\n2  -  Ex 202\n3  -  Ex 203\n4  -  Ex 204\n5  -  Ex 205\n");
            int varriant = -1;
            varriant = int.Parse(Console.ReadLine());

            switch (varriant)
            {
                case 1:
                    EX_201();
                    break;
                case 2:
                    EX_202();
                    break;
                case 3:
                    EX_203();
                    break;
                case 4:
                    EX_204();
                    break;
                case 5:
                    EX_205();
                    break;
            }
        }
    }
}
