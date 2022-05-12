using System;

namespace _304
{
    public class StringRow
    {
        public string String;
        char empty = ' ';

        public StringRow()
        {
            this.String = new string(empty, 80);
            Console.WriteLine($"String whith length 80 was created!");
        }

        public StringRow(int Length)
        {
            this.String = new string(empty, Length);
            Console.WriteLine($"String whith length {Length} was created!");
        }

        public StringRow(string String)
        {
            this.String = new string(String);
            Console.WriteLine($"String whith user's text:");
            this.String = String;
        }

        public void ShowRow()
        {
            Console.WriteLine(this.String);
        }

        public static string ReadRow()
        {
            Console.Write("Enter string: ");
            string String = Console.ReadLine();
            return String;
        }
    }
}
