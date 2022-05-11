using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_208
{//3. Відомо, що 1 дюйм дорівнює 2.54 см. Розробити додаток, що переводять дюйми в сантиметри і навпаки. Діалог з користувачем реалізувати через систему меню.
    public class Program
    {
        static void Main(string[] args)
        {
            const double inch = 2.54;
            double result, value;
            int mode;

            Console.WriteLine("1.Inch to centimeters");
            Console.WriteLine("2.Sentimeters to inch");

            mode = Int32.Parse( Console.ReadLine() );

            if (mode == 1)
            {
                Console.WriteLine("Enter inch:");
                value=Int32.Parse( Console.ReadLine() );

                result = value * 2.54;

                Console.WriteLine(result);
            }else
                {
                Console.WriteLine("Enter centimeters:");
                value = Int32.Parse(Console.ReadLine());

                result = value / inch;
                Console.WriteLine(result);

            }


        }
    }
}
