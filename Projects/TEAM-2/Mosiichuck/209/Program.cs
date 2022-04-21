using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _209
{
    class Program
    {
        //Розробити програму, яка виводить на екран горизонтальну лінію з символів. Кількість символів,
        //який використовувати символ, і яка буде лінія - вертикальна, або горизонтальна - вказує користувач
        static void Main(string[] args)
        {
            int countOfSymb = 0;
            char symb = ' ';
            string typeOfLine = "";
            Console.Write("Enter a symbol: ");
            symb = Char.Parse(Console.ReadLine());
            Console.Write("Enter count of symbols: ");
            countOfSymb = Int32.Parse(Console.ReadLine());
            Console.Write("Enter a type of line (horizontal or vertical): ");
            typeOfLine = Console.ReadLine();

            if (typeOfLine == "vertical")
            {
                for (int i = 0; i < countOfSymb; i++)
                {
                    Console.WriteLine(symb);
                }
            }
            else
            {
                for (int i = 0; i < countOfSymb; i++)
                {
                    Console.Write(symb);
                }
            }
        }
    }
}
