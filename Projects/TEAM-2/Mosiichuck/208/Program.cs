using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _208
{
    class Program
    {
        //Відомо, що 1 дюйм дорівнює 2.54 см. Розробити додаток, що переводять дюйми в сантиметри і навпаки. Діалог з користувачем реалізувати через систему меню
        static void Main(string[] args)
        {
            double inch = 2.54;
            int choise = 0;
            do
            {
                float number = 0;
                Console.WriteLine("Menu");
                Console.WriteLine("1 - Centimeters in inches\n" + "2 - Inches in centimeters\n0 - Exit");
                Console.Write("Choose your choise: ");
                choise = Int32.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        {
                            Console.Write("Enter centimeters: ");
                            number = float.Parse(Console.ReadLine());
                            Console.WriteLine("\n" + number + " centimeters: " + (number / inch) + " inches\n");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter inches: ");
                            number = float.Parse(Console.ReadLine());
                            Console.WriteLine("\t " + number + " inches: " + (number * inch) + " centimeters\n");
                            break;
                        }
                }
            } while (choise != 0);
            Console.WriteLine("Bye!");
        }
    }
}

