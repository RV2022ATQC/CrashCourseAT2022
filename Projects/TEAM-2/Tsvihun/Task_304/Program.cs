// 304
// Розробити клас StringRow, який в подальшому буде використовуватися для роботи з рядками. Клас повинен містити:
// конструктор за замовчуванням, що дозволяє створити рядок довжиною 80 символів;
// конструктор, що дозволяє створювати рядок довільного розміру;
// конструктор, який створює об'єкт і ініціалізує його рядком, отриманим від користувача.
// Клас повинен містити методи для введення рядків з клавіатури і виведення рядків на екран.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_304
{
    class StringRow
    {
        public string Line { get; set; }

        // Default constructor for 80 symbols line
        public StringRow()
        {
            StringBuilder sb = new StringBuilder(80);
        }

        // Constructor for any-lenght line
        public StringRow(int rowLength)
        {
            StringBuilder sb = new StringBuilder(rowLength);
        }

        // Consructor
        public StringRow(ref string ReadRow)
        {

        }

        public void ShowRow()
        {
            Console.WriteLine("");
        }

        public string ReadRow()
        {
            Console.WriteLine("Enter line:")
            string inputLine = Console.ReadLine();
            return inputLine;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            StringRow row = new StringRow();
        }
    }
}
