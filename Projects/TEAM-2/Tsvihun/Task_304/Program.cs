// 304
// Розробити клас StringRow, який в подальшому буде використовуватися для роботи з рядками. Клас повинен містити:
// конструктор за замовчуванням, що дозволяє створити рядок довжиною 80 символів;
// конструктор, що дозволяє створювати рядок довільного розміру;
// конструктор, який створює об'єкт і ініціалізує його рядком, отриманим від користувача.
// Клас повинен містити методи для введення рядків з клавіатури і виведення рядків на екран.

using System;
using System.Text;

namespace Task_304
{
    public class StringRow
    {
        public string Line { get; set; }
        StringBuilder sb = new StringBuilder();

        // Default constructor for 80 symbols line
        public StringRow()
        {
            sb.Length = 80;
            Console.WriteLine($"Default constructor with {sb.Length} symbols.");

            // Check the length of line adding text to the end of it
            sb.Append("some text");

            this.Line = sb.ToString();
        }

        // Constructor for any-lenght line
        public StringRow(int rowLength)
        {
            sb.Length = rowLength;
            Console.WriteLine($"Constructor with {sb.Length} symbols.");

            // Check the length of line adding text to the end of it
            sb.Append("some text");

            this.Line = sb.ToString();
        }

        // Consructor with user's text
        public StringRow(string read)
        {
            Console.WriteLine($"Constructor with user's text.");
            this.Line = read;
        }

        public void ShowRow()
        {
            Console.WriteLine(this.Line);
        }

        public static string ReadRow()
        {
            Console.WriteLine("Enter line:");
            string read = Console.ReadLine();
            return read;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            StringRow row = new StringRow();
            row.ShowRow();

            StringRow row2 = new StringRow(15);
            row2.ShowRow();

            StringRow row3 = new StringRow(StringRow.ReadRow());
            row3.ShowRow();
        }
    }
}
