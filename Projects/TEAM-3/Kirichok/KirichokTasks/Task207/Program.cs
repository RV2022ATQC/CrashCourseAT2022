using System;
//2. Дано натуральне число а (a <100). Напишіть програму, що виводить на екран кількість цифр в цьому числі і суму цих цифр

namespace Task207
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a1, a2, a3;
            Console.Write("Введiть число менше 100 ");
            a3 = int.Parse(Console.ReadLine());
            a1 = a3 % 10;
            a2 = (a3 - a1) / 10;

            if
            
                (a2 == 0) Console.Write("Кiлькiсть цифр - одна цифра, ");
            
            else
            
                Console.Write("Кiлькiсть цифр - двi цифри, ");
            
                Console.Write("сума цифр дорiвнює {0}", a2 + a1);
            Console.ReadKey();
        }
    }
}
