using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float First = 0;
            Console.WriteLine("Enter first Number");
            First = Convert.ToSingle(Console.ReadLine());
            float Second = 0;
            Console.WriteLine("Enter second Number");
            Second = Convert.ToSingle(Console.ReadLine());
            float AVG;
            AVG = (First + Second) / 2;
            Console.Write("AVG=");
            Console.WriteLine(AVG);
        }
    }
}
