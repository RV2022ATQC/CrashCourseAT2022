using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_209_216
{
    static class tasks_functions
    {
        /*Розробити програму, яка виводить на екран горизонтальну лінію з символів. 
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
        /*
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

    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            char c;
            int n;
            byte flag;
            Console.WriteLine("Input symbol,number,flag(0/!0)");
            c = char.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            flag = byte.Parse(Console.ReadLine());
            tasks_functions.Row(c, n, flag);*/
            Console.WriteLine("Enter the number");
           string s = Console.ReadLine();
           Console.WriteLine( tasks_functions.DigitNumber(s));
            Console.ReadLine();
        }
    }
}
