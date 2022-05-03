using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team1_group
{
    class Program
    {
        static void Main(string[] args)
        {
            if (military_unit.space[100, 200] == null) Console.WriteLine("spase is empty");
                abrams a = new abrams(100,200,20,10,100,0,"Abrams1");
            if (military_unit.space[100, 200] != null)
            {
                //з простором можна працювати як military_unit.space[x, y] або abrams.space[x,y]!
                abrams b = (abrams)military_unit.space[100, 200];
                Console.WriteLine("Hello! I am "+b.getname());
            }            Console.ReadLine();
        }
    }
}
