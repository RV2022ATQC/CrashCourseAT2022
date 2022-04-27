using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _216
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Create program for array making and reversing it

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hallo. I am a program rof array reversing.\nEnter lenght of your array:");
            int lenght = 0; 
            lenght = int.Parse(Console.ReadLine());    // Вводимо довжину масиву

            Console.WriteLine("Please fill up your array:");
            int [] array = new int[lenght];            // Заповнюємо масив
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" ");
                array[i] = int.Parse(Console.ReadLine());
            }
           
            Console.WriteLine("Your array: ");         // Виводимо масив
            for (int i = 0; i<array.Length; i++)
                Console.Write(array[i] + ", ");

            Console.WriteLine("\nArray reverse: ");    // Виводимо масив "задом наперед"
            for (int i = array.Length - 1; i >= 0; i--)
                Console.Write(array[i] + ", ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\nRussian warship, go fuck yourself!!! ");



        }
    }
}
