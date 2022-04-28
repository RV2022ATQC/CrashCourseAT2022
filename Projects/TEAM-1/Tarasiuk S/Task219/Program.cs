using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasl219
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Create program for array making and finding smallest odd number from it.

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hallo. I am a program rof array reversing.\nEnter lenght of your array:");
            int lenght = 0;
            lenght = int.Parse(Console.ReadLine());    // Вводимо довжину масиву

            Console.WriteLine("Please fill up your array:");
            int[] array = new int[lenght];            // Заповнюємо масив
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Your array: ");         // Виводимо масив
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + ", ");


            int? smallestOddNumber = null;          // Змінна в яку будемо записувати одд намбери
            
            foreach(int i in array)
            {
                if (i%2 != 0)                            // Вибираємо числа як після ділення по модулю на 2 не мають залишку
                    if (!smallestOddNumber.HasValue || i < smallestOddNumber) // Порівнюємо кожне непарне з попереднім непарним
                { 
                    smallestOddNumber = i;
                 }
            }
            if (smallestOddNumber != null)                 // виводимо
                Console.WriteLine("\n\nSmallest odd number is - " + smallestOddNumber);
            else                                          // Якщо немає одів тоді
                Console.WriteLine("\n\nThere are any odd numbers in arrey");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\nRussian warship, go fuck yourself!!! ");



        }
    }
}
