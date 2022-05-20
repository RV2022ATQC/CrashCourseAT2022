using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221
{
    class Program
    {
        //Написати overload методи RemoveFromString, які приймають текст і видаляють з нього або певний набір символів, або символ\символи за порядковим номером в тексті.
        //Реалізувати використання аргументів за замовчуванням та статичних полів\методів
        static void Main(string[] args)
        {
            string str = "";
            List<char> listChars = new List<char>();
            List<int> listNumbers = new List<int>();

            Console.Write("Enter some text: ");
            str = Console.ReadLine();
            Console.WriteLine("Enter 2 chars which you want to remove : ");
            listChars.Add(char.Parse(Console.ReadLine()));
            listChars.Add(char.Parse(Console.ReadLine()));
            Console.WriteLine("Enter 2 positions which you want to remove : ");
            listNumbers.Add(Int32.Parse(Console.ReadLine()));
            listNumbers.Add(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("RemoveFromString with chars");
            str = RemoveFromString(str, listChars);
            Console.WriteLine("RemoveFromString with int");
            str = RemoveFromString(str, listNumbers);
            Console.WriteLine(str);
        }

        private static string RemoveFromString(string str, List<char> listChars)
        {
            foreach (var item in listChars)
            {
                str = str.Replace(item.ToString(), "");
            }
            return str;
        }
        private static string RemoveFromString(string str, List<int> listNumbers)
        {
            foreach (var item in listNumbers)
            {
                str = str.Remove(item, 1);
            }
            return str;
        }

    }
}