using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzhyharTasks

{

    public class Tasks
    {

        public Tasks task201()  
            /*Напишіть програму, яка обчислює середнє арифметичне двох чисел.*/
        {
            Console.Write("Enter a first digit: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a second digit: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Arithmetic mean:  {(a + b) / 2}");
            return this;

        }
        public Tasks task202() 
            /* Напишіть програму, яка переводить гривні в $, Є.*/
        {
            Console.Write("Enter the number of hryvnias:: ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"In dollars:  { d / 29.24} In euros: {d / 31.92}");
            return this;
        }
        public Tasks task203() 
            /*"3. Виведіть на екран наступний текст:
            To be or not to be
            \ Shakespeare \" */
        {
            Console.WriteLine($"To be or not to be \n \\Shakespeare\\ ");
            return this;
        }
        public Tasks task204()
            /*Напишіть програму, яка обчислює квадрат будь-якого, введеного числа*/
        {
            Console.Write("Enter a digit: ");
            double g = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Square digit: {g * g}");
            return this;
        }
        public Tasks task205()
            /*Введіть три числа і виведіть на екран значення суми і добуток цих чисел.*/
        {
            Console.Write("Enter a first digit: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a second digit: ");
            double e = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a third digit: ");
            double f = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Sum of digits:  {c + e + f} Product of digits: {c * e * f} ");
            return this;
        }
        public Tasks task206()
            /*Напишіть програму, яка перевіряє число, введене з клавіатури на парність.*/
        {
            Console.Write("Enter a digit: ");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
                Console.WriteLine("Digit is even ");
            else
                Console.WriteLine("Digit is odd");
            return this;
                                }
        public Tasks task207()
            /*Дано натуральне число а(a<100). Напишіть програму, що виводить на екран кількість цифр в цьому числі і суму цих цифр*/
        {
            Console.WriteLine("Enter a digit from 1 to 100");
            static int CountOfDigits(int a) { return a < 10 ? 1 : 2; }
            static int SumOfDigits(int a) { return a < 10 ? a : a % 10 + a / 10; }
            {
                int a = 100;
                while (a >= 100) a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(String.Format("Count of digits: {0}\nSum of digits: {1}",
                    CountOfDigits(a), SumOfDigits(a)));
                return this;
            }
        }
        public Tasks task208()
            /* Відомо, що 1 дюйм дорівнює 2.54 см.Розробити додаток, що переводять дюйми в сантиметри і навпаки.Діалог з користувачем реалізувати через систему меню.*/
        {
            double d = 2.54;
            string f;
            Console.WriteLine("Enter: 1 - inches in cm \n2 - cm in inches)");
            f = Console.ReadLine();
            if (f == "1")
            {
                Console.WriteLine("Enter the number of inches");
                double a = Convert.ToDouble(Console.ReadLine());
                a *= d;
                Console.WriteLine(a + " sm");
            }
            else if (f == "2")
            {
                Console.WriteLine("Enter the number of centimeters");
                double a = Convert.ToDouble(Console.ReadLine());
                a /= d;
                Console.WriteLine(a + " inch");
            }
            else
                Console.WriteLine("You enterd wrong number!");
            return this;
        }
        public Tasks task209()
           /* Розробити програму, яка виводить на екран горизонтальну лінію з символів.Кількість символів, який використовувати символ, і яка буде лінія - вертикальна, або горизонтальна - вказує користувач.*/
        {
            char s;
            int n;
            Console.Write("Enter a one symbol: ");
            s = Convert.ToChar(Console.ReadLine());             
            Console.Write("Enter a number of  symbol: \n");            
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter: 1 - for vertical \n2 - for horizontal \n");
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
                while (n != 0)
                {
                    Console.WriteLine(s);
                    n--;
                }
            else if (choice == 2)
                while (n != 0)
                {
                    Console.Write(s);
                    n--;
                }           
            else Console.WriteLine("You entered wrong number");
            Console.WriteLine("End of program \n");
            return this;
        }

        public Tasks task212()
            /* Користувач вводить з клавіатури число - програма повинна показати скільки в даному числі цифр. Число вводиться повністю в одну змінну.
            Примітка: Наприклад, користувач ввів число 11123445555. На екрані має з'явитися повідомлення про те, що в числі 5 цифр."*/
        {
            int number, i = 0;
            Console.WriteLine("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            for (; number > 0; i++) 
            {
                number /= 10;
            }
                Console.WriteLine($"Count of digits: {i} ");
                return this;            
        }
        
        public Tasks task213()
            /*Користувач вводить з клавіатури число, необхідно перевернути його (число) і вивести на екран.
            Примітка: Наприклад, користувач ввів число 12345. На екрані має з'явитися число навпаки - 54321."*/
        {

            int number, result = 0;
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            while (number > 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }
            Console.WriteLine($"backwards result: {result} "); 
            return this;
        }
        public Tasks task214()
            /*Користувач вводить з клавіатури число, необхідно показати на екран суму його цифр.
            Примітка: Наприклад, користувач ввів число 12345. На екрані має з'явитися повідомлення про те, що сума цифр числа 15."*/
        {
            int number, sum, i = 0;            
                Console.Write("Enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());
                while (number > 0)
                {
                    sum = number % 10;
                    number /= 10;
                    i += sum;
                }
                Console.WriteLine($"Sum of digits: {i} ");
                return this;
        }
        public Tasks task215()
            /* Написати програму, яка виводить на екран - наступну фігуру:
            ""*********************                                                                                                                                                                                                        
            *                           *                                                                                                                                                                                                        
            *                           *                                                                                                                                                                                                        
            *                           *                                                                                                                                                                                                        
            *                           *                                                                                                                                                                                                        
            *********************                                                                                                                                                                                                        
            ширина і висота фігури встановлюються користувачем з клавіатури."*/
        {
            int a, b;
            Console.Write("Enter a width: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a height: ");
            b = Convert.ToInt32(Console.ReadLine());         
            for (int j = 0; j < b; j++)
            {
                for (int i = 0; i < a; i++)
                {
                    if (j == 0 || j == b - 1) Console.Write("*");
                    else if (i == 0 || i == a - 1) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            return this;
        }
    }
}

