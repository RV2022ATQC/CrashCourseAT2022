using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float hrn = 0;
            Console.WriteLine("Enter hryvnas");
            hrn = Convert.ToSingle(Console.ReadLine());
            
            
            double dollar = hrn/(32.45);
       
          
            Console.WriteLine($"{dollar} Dollar");

            double euro = hrn / (34.80);
           
            Console.WriteLine($"{euro} Euro");
            




        }
    }
}
