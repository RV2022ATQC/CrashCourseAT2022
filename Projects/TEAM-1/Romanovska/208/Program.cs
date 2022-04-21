using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _208
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Відомо, що 1 дюйм дорівнює 2.54 см. 
              Розробити додаток, що переводять дюйми в сантиметри і навпаки. 
              Діалог з користувачем реалізувати через систему меню.*/

            string answer = "1";
            Console.WriteLine("Enter which metric system do you want to convert: \n " +
                "1 - to convert inches to cm; \n 2 - to convert cm to inches");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                double cm;
                Console.WriteLine("Enter quantity of inches to convert: ");
                double inch = Convert.ToDouble(Console.ReadLine());
                cm = inch * 2.54;
                Console.WriteLine("{0} inch : {1} cm", inch, cm);

            }
            else
            {
                double inch;
                Console.WriteLine("Enter quantity of cm to convert: ");
                double cm = Convert.ToDouble(Console.ReadLine());
                inch = cm / 0.39370;
                Console.WriteLine("{0} cm : {1} inches", cm, inch);
            }
        }
    }
}
