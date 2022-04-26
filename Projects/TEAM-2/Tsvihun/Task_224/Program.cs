// 224
// Дано масив випадкових чисел в діапазоні від -20 до +20. Необхідно знайти позиції крайніх негативних елементів
// (самого лівого негативного елементу і самого правого негативного елементу) і впорядкувати елементи, що знаходяться між ними.

using System;

namespace Task_224
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] random_array = new int[15];
            Random random = new Random();
            var count_negative = 0;

            // Create random array
            for (int i = 0; i < random_array.Length; i++)
            {
                random_array[i] = random.Next(-20, 20);
                Console.Write($"{random_array[i]} ");

                if (random_array[i] < 0)
                {
                    count_negative++;
                }
            }

            // Find the leftmost and rightmost position of negatives
            if (count_negative > 0)
            {
                int left_position = random_array[0];
                int right_position = random_array[random_array.Length - 1];

                for (int i = 0; i < random_array.Length; i++)
                {
                    if (random_array[i] < 0)
                    {
                        left_position = i;
                        break;
                    }
                }

                for (int i = random_array.Length - 1; i >= 0; i--)
                {
                    if (random_array[i] < 0)
                    {
                        right_position = i;
                        break;
                    }
                }

                Console.WriteLine($"\nLeft position = {left_position}. Right position = {right_position}");

                // Sort array between left and right negatives
                int temp;
                for (int i = left_position + 1; i < right_position - 1; i++)
                {
                    for (int j = i + 1; j < right_position; j++)
                    {
                        if (random_array[i] > random_array[j])
                        {
                            temp = random_array[i];
                            random_array[i] = random_array[j];
                            random_array[j] = temp;
                        }
                    }
                }

                foreach (int i in random_array)
                {
                    Console.Write($"{i} ");
                }
            }
            else { Console.Write("\nNo negatives at all"); }
        }
    }
}
