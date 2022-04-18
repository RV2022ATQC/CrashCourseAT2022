using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_206___208
{
    class Program
    {
        
        static void EX_206()//1. Напишіть програму, яка перевіряє число, введене з клавіатури на парність.
        {
            float number = 0;
            
            Console.WriteLine("Enter number: ");
            number = float.Parse(Console.ReadLine());

            if (number % 2 == 0)
                Console.WriteLine("\n\t" + number + " is pair.");
            else if (number % 2 != 0)
                Console.WriteLine("\n\t" + number + " is pair.");
            else
                Console.WriteLine("ERROR");

        }

       
        static void EX_207() //2. Дано натуральне число а (a <100). Напишіть програму, що виводить на екран кількість цифр в цьому числі і суму цих цифр
        {
            int numberInt = 678, sum = 0;
            string numberStr;

            if (numberInt < 0 || numberInt > 100)//checking for right number
            {
                Random rd = new Random();
                numberInt = rd.Next(0, 100);
            }

            numberStr = numberInt.ToString();
            for (int i = 0; i < numberStr.Length; i++)
                sum += (int)numberStr[i]-48;

            Console.WriteLine(numberInt +" have "+numberStr.Length+" symbols and sum of numbers is "+sum);
            Console.ReadLine();

        }

        static void EX_208() //3. Відомо, що 1 дюйм дорівнює 2.54 см.Розробити додаток, що переводять дюйми в сантиметри і навпаки. Діалог з користувачем реалізувати через систему меню.

        {
            int varriantInt=0;
            float numberInp=0, rezConverted = 0, koofIncCent = 2.54f;
            do//working untill user enter 0
            {
                Console.WriteLine("\nEnter varriant of work:\n\n   1\t:to convert inches to centimeters.\n\n   2\t:to convert centimeters to inches.\n\n   0\t:to exit.\n");
                varriantInt = int.Parse(Console.ReadLine());

                while(varriantInt != 0 && varriantInt != 1 && varriantInt != 2)//checking for right input
                {
                    Console.WriteLine("\nWrong varriant, try again\n");
                    varriantInt = int.Parse(Console.ReadLine());
                }

                switch(varriantInt)
                {
                    case 1:
                        Console.WriteLine("Enter amount in inches:");
                        numberInp = float.Parse(Console.ReadLine());
                        rezConverted = numberInp * koofIncCent;
                        Console.WriteLine("\t" + numberInp + " inches  =  " + rezConverted + " centimeters");
                        break;

                    case 2:
                        Console.WriteLine("Enter amount in centimetrs:");
                        numberInp = float.Parse(Console.ReadLine());
                        rezConverted = numberInp / koofIncCent;
                        Console.WriteLine("\t" + numberInp + " centimeters  =  " + rezConverted + " inches");
                        break;

                    case 3:
                        break;

                    default:
                        Console.WriteLine("ERROR");
                        break;
                }

                Console.WriteLine("\n\n\n\n");
            }
            while (varriantInt != 0);

        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter:\n\n6  -  Ex 206\n7  -  Ex 207\n8  -  Ex 208\n\n");
            int varriant = -1;
            varriant = int.Parse(Console.ReadLine());

            switch (varriant)
            {
                case 1:
                    EX_206();
                    break;
                case 2:
                    EX_207();
                    break;
                case 3:
                    EX_208();
                    break;
            }
        }
    }
}
