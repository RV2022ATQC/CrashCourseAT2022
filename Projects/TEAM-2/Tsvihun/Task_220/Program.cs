// 220
// Написати overload методи Add які в залежності від параметрів або додають цифрові значення, або об'єднують введені тексти.
// Передбачити аргументи за замовчуванням і використання статичних полів\методів

using System;

namespace Task_220
{
    public class Light
    {
       static int min_lamp = 20;

        int AddLamps(int lamp1, int lamp2 = 100)
        {            
            Console.Write($"Total power of 2 lamps = {lamp1 + lamp2} Watts.\n");
            if (lamp1 > min_lamp || lamp2 > min_lamp) { Console.Write($"\tPlease don't use Soviet lamps.\n"); }
            return lamp1 + lamp2;            
        }

        static string AddLamps(string place1, string place2 = "kitchen")
        {
            Console.WriteLine($"Lamps are in two places: {place1} and {place2}");
            return place1 + place2;
        }
        
        static void Main(string[] args)
        {
            Light light1 = new Light();
            Light light2 = new Light();

            light1.AddLamps(60);
            light2.AddLamps(10, 8);
            
            Light.AddLamps("WC");
            Light.AddLamps("kitchen", "bedroom");
        }
    }
}
