//Розробити клас StringRow, який в подальшому буде використовуватися для роботи з рядками. Клас повинен містити:
//  конструктор за замовчуванням, що дозволяє створити рядок довжиною 80 символів;
//  конструктор, що дозволяє створювати рядок довільного розміру;
//  конструктор, який створює об'єкт і ініціалізує його рядком, отриманим від користувача.
//Клас повинен містити методи для введення рядків з клавіатури і виведення рядків на екран.
using System.Text;

namespace _304
{
    public class StringRow
    {
        public StringBuilder row { get; private set; } = new StringBuilder();

        public StringRow()
        {
            row.Length = 80;
        }

        public StringRow(int lenght)
        {
            lenght = Math.Abs(lenght);
            row.Length = lenght;
        }

        public StringRow(StringBuilder row)
        {
            this.row = new StringBuilder(row.ToString());
        }

        public StringRow(string row)
        {
            this.row = new StringBuilder(row);
        }

        public override string ToString()
        {
            return row.ToString();
        }

        public void ReadRow()
        {
            Console.Write("Enter row: ");
            var str = Console.ReadLine();
            this.row = new StringBuilder(str);
        }

        public void Show()
        {
            Console.WriteLine(row);
        }
    }
}