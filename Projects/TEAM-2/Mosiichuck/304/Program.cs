using System;

namespace _304
{
    class Program
    {
        //Розробити клас StringRow, який в подальшому буде використовуватися для роботи з рядками. Клас повинен містити:
        //конструктор за замовчуванням, що дозволяє створити рядок довжиною 80 символів;
        //конструктор, що дозволяє створювати рядок довільного розміру;
        //конструктор, який створює об'єкт і ініціалізує його рядком, отриманим від користувача.
        //Клас повинен містити методи для введення рядків з клавіатури і виведення рядків на екран.
        static void Main(string[] args)
        {
            StringRow row = new StringRow();
            Console.WriteLine("Enter row to 80 symbols: ");
            row.ReadLine(Console.ReadLine());
            row.PrintLine();

            Console.WriteLine();
            StringRow row2 = new StringRow(20);
            Console.WriteLine("Enter row to 20 symbols: ");
            row2.ReadLine(Console.ReadLine());
            row2.PrintLine();

            Console.WriteLine();
            Console.WriteLine("Enter row: ");
            StringRow row3 = new StringRow(Console.ReadLine());
            row3.PrintLine();
        }
    }
}
