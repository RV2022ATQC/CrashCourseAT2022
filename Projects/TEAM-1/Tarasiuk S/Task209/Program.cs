using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task209
{
    internal class Program
    {
        static void Main(string[] args)
        { // Create program that displays line of symbols. Symbol, amount of symbols and 
          // what kind of line (horisontal/vertical) user needs to be chosen by itself.
            
            Console.WriteLine("Hallo! I am a program for making lines with your symbol!\n" +
                "Please chose your symbol.\n");
            char symbol;
            symbol = Convert.ToChar(Console.ReadLine());       //Вводимо символ

            Console.WriteLine("Then I want to ask U to enter amount of symbols for your line.\n");
            int amount = 0;
            amount = Convert.ToInt32(Console.ReadLine());      //Вводимо кількість символів

            Console.WriteLine("Choose kind of line U want. There is options\n" +
                " Press F1 for horisontal.\n Press F2 for vertikal.");
            ConsoleKey Key = Console.ReadKey().Key;

            while (Key != ConsoleKey.F1 && Key != ConsoleKey.F2)        //Перевірка введеного типу поки не буде валідного вибору
            {
                Console.ForegroundColor = ConsoleColor.Red;            // Міняємо колір на червоний
                Console.WriteLine("Only F1 and F2 avaliable\n");       // Виводимо ерор і даємо нову спробу
                Console.ForegroundColor = ConsoleColor.Gray;
                Key = Console.ReadKey().Key;

            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n    Enjoy!\n");

            switch (Key)                            // оператор множинного вибору 
            {

                case ConsoleKey.F1:
                    for (int i = 0; i < amount; i++)          //Для горизонтальних 
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(symbol);
                    }
                    Console.Write("\n");
                    break;

                case ConsoleKey.F2:
                    for (int i = 0; i < amount; i++)          //Для вертикальних
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(symbol);
                    }
                    break;
            }
        }
    }
}         
    

