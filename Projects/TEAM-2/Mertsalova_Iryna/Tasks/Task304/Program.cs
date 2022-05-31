using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task304
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
            row.fillLine();
            
            StringRow row2 = new StringRow(15);
            row2.fillLine();

            StringRow row3 = new StringRow("my line");
            row3.printLine();
        }
    }
}
