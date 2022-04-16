using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_209_216
{
    static class tasks_functions
    {
        /* 209 Розробити програму, яка виводить на екран горизонтальну лінію з символів. 
     Кількість символів, який використовувати символ, і яка буде лінія - вертикальна, або горизонтальна - 
     вказує користувач.*/
        public static int Row(char c, int number, byte flag)
        {
            int i;
            if (flag == 0)
                for (i = 0; i < number; i++) Console.Write(c);
            else
                for (i = 0; i < number; i++) Console.WriteLine(c);
            return 0;
        }
        /*212
          Користувач вводить з клавіатури число - програма повинна показати скільки в даному числі цифр.
          Число вводиться повністю в одну змінну.
Примітка: Наприклад, користувач ввів число 11123445555.
На екрані має з'явитися повідомлення про те, що в числі 5 цифр.
         */
        public static int DigitNumber(string s)
        {
            int count = 1;
            for (int i = 1; i < s.Length; i++)
            {
                count++;
                for (int j = 0; j < i; j++)
                    if (s[j] == s[i]) { count--; break; }
            }
            return count;
        }
        /*213 Користувач вводить з клавіатури число, необхідно перевернути його (число) і вивести на екран.
        Примітка: Наприклад, користувач ввів число 12345. На екрані має з'явитися число навпаки - 54321*/
        public static int ReverseNumber(int n)
        {
            while (n > 0) { Console.Write(n % 10); n /= 10; }
            return 0;
        }
        /*214 Користувач вводить з клавіатури число, необхідно показати на екран суму його цифр.
Примітка: Наприклад, користувач ввів число 12345. На екрані має з'явитися повідомлення про те, що сума цифр числа 15.*/
        public static int SumNumber(int n)
        {
            int s = 0;
            while (n > 0) { s += n % 10; n /= 10; }
            return s;
        }
        /* 215 Написати програму, яка виводить на екран - наступну фігуру:
"*********************                                                                                                                                                                                                        
*                           *                                                                                                                                                                                                        
*                           *                                                                                                                                                                                                        
*                           *                                                                                                                                                                                                        
*                           *                                                                                                                                                                                                        
*********************                                                                                                                                                                                                        
ширина і висота фігури встановлюються користувачем з клавіатури.*/
        public static int FigurePrint(int m, int n)
        {
            for (int i = 0; i < n; i++) Console.Write('*');
           Console.WriteLine();
            for (int j = 0; j < m - 2; j++)
            {
                Console.Write('*');
                for (int i = 0; i < n - 2; i++) Console.Write(' ');
                Console.Write('*');
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++) Console.Write('*');

            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter task number(209,212-215)");
            int k = int.Parse(Console.ReadLine());
            switch (k) {
                case 209:
                char c;
                int n;
                byte flag;
                Console.WriteLine("Input symbol,number,flag(0/!0)");
                c = char.Parse(Console.ReadLine());
                n = int.Parse(Console.ReadLine());
                flag = byte.Parse(Console.ReadLine());
                tasks_functions.Row(c, n, flag);
                break;
                case 212:
             Console.WriteLine("Enter the number");
            string s = Console.ReadLine();
            Console.WriteLine( tasks_functions.DigitNumber(s));
             Console.ReadLine();
                    break;
                case 213:
                    int num = int.Parse(Console.ReadLine());
            tasks_functions.ReverseNumber(num);
            Console.ReadLine();
                 break;
                case 214:
             Console.WriteLine("Enter the number");
             int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("сума цифр="+ tasks_functions.SumNumber(num1));
             Console.ReadLine();
               break;
                case 215:
                    Console.WriteLine("Enter the figure size m,n");
            int m = int.Parse(Console.ReadLine()), n1 = int.Parse(Console.ReadLine());
            tasks_functions.FigurePrint(m, n1);
            Console.ReadLine();
                    break;
                default:  Console.WriteLine("На жвль, інші незробив"); break;
            }
            }
    }
}
