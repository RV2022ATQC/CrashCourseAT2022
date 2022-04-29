// 221
// Написати overload методи RemoveFromString, які приймають текст і видаляють з нього або певний набір символів, або символ\символи за порядковим номером в тексті.
// Реалізувати використання аргументів за замовчуванням та статичних полів\методів
using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_221
{
    
    class Program
    {
        static string text = "Antonio and other members want to do some work together";
        static string redudant_text = "aAr";


        // Method removes from string certain char set (redudant_text)
        static string remove_text(string input_text, string text_toremove = "e")
        {
            string output_text = "";
            List<char> charlist = input_text.ToList();
            var outputlist = charlist.Except(text_toremove);

            foreach (char c in outputlist)
            {
                output_text += c;
            }

            return output_text;
        }


        // Method removes from string a char by index
        static string remove_text(string input_text, int index_toremove)
        {
            string output_text = "";

            List<char> charlist = input_text.ToList();
            charlist.Remove(input_text[index_toremove]);

            foreach (char c in charlist)
            {
                output_text += c;
            }

            return output_text;           
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Program.remove_text(text, redudant_text));
            Console.WriteLine(Program.remove_text(text));
            Console.WriteLine(Program.remove_text(text, 3));

        }
    }
}