using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_222___226
{
    class Program
    {
        static void EX_222()
        {

        }
        static void EX_224()
        {
           
        }
        static void EX_226()
        {

        }
    
    static void Main(string[] args)
        { 
            Console.WriteLine("Enter:\n\n22  -  Ex 222\n24  -  Ex 224\n26  -  Ex 226\n\n");
            int varriant = -1;
            varriant = int.Parse(Console.ReadLine());

            switch (varriant)
            {
                case 22:
                     var exercise22 = new EX_222();//Написати перевантажені функції для знаходження коренів лінійного (a * x + b = 0) і квадратного (a * x2 + b * x + c = 0) рівнянь. Зауваження: у функції передаються коефіцієнти рівнянь.
            exercise22.main();
                    break;
                case 24:
             var exercise24 = new EX_224();//Написати перевантажені функції для знаходження коренів лінійного (a * x + b = 0) і квадратного (a * x2 + b * x + c = 0) рівнянь. Зауваження: у функції передаються коефіцієнти рівнянь.
            exercise24.main();
                    break;
                case 26:
            var exercise26 = new EX_226();//Написати перевантажені функції для знаходження коренів лінійного (a * x + b = 0) і квадратного (a * x2 + b * x + c = 0) рівнянь. Зауваження: у функції передаються коефіцієнти рівнянь.
            exercise26.main();
                    break;
            }
        }
    }
}
