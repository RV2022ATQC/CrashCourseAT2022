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
                " Enter 1 for horisontal.\n Enter 2 for vertikal.");
            int LineType = 0;
            LineType = Convert.ToInt16(Console.ReadLine());
            while (LineType != 1 && LineType != 2)         //Перевірка введеного типу поки не буде валідного вибору
            {
                Console.WriteLine("There no such an option re-enter again\n");
                LineType = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("\nEnjoy!\n");

            switch (LineType)                            // оператор множинного вибору 
            {

                case 1:
                for (int i = 0; i < amount; i++)          //Для горизонтальних 
                {
                    Console.Write(symbol);
                }
                Console.Write("\n");
                break;
              
                case 2:
               {
                for (int i = 0; i < amount; i++)          //Для вертикальних
               {
                   Console.WriteLine(symbol);
               }
                break;

           }
              
            }
        }
    }
}         
    

