using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task221
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Написати overload методи RemoveFromString, які приймають текст і видаляють з нього або певний набір символів, або символ\символи за порядковим номером в тексті.
            //Реалізувати використання аргументів за замовчуванням та статичних полів\методів

            Console.WriteLine("Enter text");
            string text = Console.ReadLine();

            Console.WriteLine("Enter 1 for deleting phrase, 2 for deleting symbol by number: ");
            int t = Convert.ToInt32(Console.ReadLine());
            if (t == 1)
            {
                Console.WriteLine("Enter phrase: ");
                string phrase = Console.ReadLine();

                RemoveFromString(text, phrase);
            }
            else if (t == 2)
            {
                Console.WriteLine("Enter amount of symbols you want to delete: ");
                int amount = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter symbol(s): ");
                string symbols = Console.ReadLine();

                RemoveFromString(text, symbols, amount);
            }

        }
        static void RemoveFromString(string text, string phrase)
        {
            bool t = text.Contains(phrase);
            if (t == true)
            {
                int index = text.IndexOf(phrase);
                text = text.Remove(index, phrase.Length);

                Console.WriteLine(text);
            }
            else if (t == false)
            {
                Console.WriteLine("Phrase is not found");
            }
        }
        static void RemoveFromString(string text, string symbols, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                bool t = text.Contains(symbols[i]);
                if (t == true)
                {
                    text = text.Remove(text.IndexOf(symbols[i]), 1);

                    RemoveFromString(text, symbols, amount);
                }
            }
            Console.WriteLine(text);
        }
    }
}
