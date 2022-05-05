// 221
// Написати overload методи RemoveFromString, які приймають текст і видаляють з нього або певний набір символів, або символ\символи за порядковим номером в тексті.
// Реалізувати використання аргументів за замовчуванням та статичних полів\методів
using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_221{
    
    class Program
    {
        static string text = "Antonio and other members want to do some work together";
        static string redudantText = "aAr";


        // Method removes from string certain char set (redudantText)
        static string RemoveText(string inputText, string textToRemove = "e")
        {
            List<char> charlist = inputText.ToList();
            var correctlist = charlist.Except(textToRemove);

            var outputlist = new string(correctlist.ToArray());

            return outputlist;
        }


        // Method removes from string a char by index
        static string RemoveText(string inputText, int indexToRemove)
        {
            List<char> charlist = inputText.ToList();
            charlist.Remove(inputText[indexToRemove]);

            var outputText = new string(charlist.ToArray());

            return outputText;           
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Program.RemoveText(text, redudantText));
            Console.WriteLine(Program.RemoveText(text));
            Console.WriteLine(Program.RemoveText(text, 3));
        }
    }
}