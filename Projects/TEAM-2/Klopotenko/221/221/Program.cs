using System;
using System.Collections.Generic;


namespace _221
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World";
            Console.Write("Enter string you would like to change: ");
            str = Console.ReadLine();
            List<char> chars = new List<char>();
            List<byte> position = new List<byte>();
            Console.WriteLine("Enter chars you would like to remove:");
            chars.Add(char.Parse(Console.ReadLine()));
            chars.Add(char.Parse(Console.ReadLine()));
            chars.Add(char.Parse(Console.ReadLine()));
            Console.WriteLine("Enter position where you would like to remove chars:"); // counting from 0 (1 char = 0...)
            position.Add(byte.Parse(Console.ReadLine()));
            position.Add(byte.Parse(Console.ReadLine()));
            position.Add(byte.Parse(Console.ReadLine()));
            Console.WriteLine($"Using RemoveFromString for removing " +
                $"by chars: {RemoveFromString(str, chars)}");
            Console.WriteLine($"Using RemoveFromString for removing " +
                $"by chars's position: {RemoveFromString(str, position)}");
        }
        private static string RemoveFromString(string str, List<char> chars)
        {
            foreach(var i in chars)
            {
                str = str.Replace(i.ToString(), "");
            }
            return str;
        }
        private static string RemoveFromString(string str, List<byte> position)
        {
            List<char> chars = new List<char>();
            for (int i = 0; i < 3; i++)
            {
                chars.Add(Convert.ToChar((str[position[i]])));
            }
            str = RemoveFromString(str, chars);
            return str;
        }
    }
}
