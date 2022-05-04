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
            /*
            if (military_unit.space[100, 200] == null) Console.WriteLine("spase is empty");
                abrams a = new abrams(100,200,20,10,100,0,"Abrams1");
            if (military_unit.space[100, 200] != null)
            {
                //з простором можна працювати як military_unit.space[x, y] або abrams.space[x,y]!
                abrams b = (abrams)military_unit.space[100, 200];
                Console.WriteLine("Hello! I am "+b.getname());
            }*/
            //породжуэмо танчики випадково
            Random rnd = new Random();      


            for (int i = 0; i < 20; i++)
            {
                int x= rnd.Next(500), y= rnd.Next(500);
                military_unit.space[x, y] = new abrams(x, y, 20, 30, 100,rnd.Next(2).ToString(), "Abrams1");
            }
            for (int i = 0; i < 16; i++)
            {
                int x = rnd.Next(500), y = rnd.Next(500);
                if (military_unit.space[x, y] == null)
                    military_unit.space[x, y] = new Vilkha_unit(x, y, 50, 20, 50, rnd.Next(2).ToString(), "Vilkha");
                else
                    i--;
            }
            //загальний ігровий цикл
            for (int i=0;i<15;i++)
            {
                //перегляд всіх об'єктів та їх дія
                for (int j = 0; j < 500; j++)
                    for (int k = 0; k < 500; k++)
                        if (military_unit.space[j, k] != null) military_unit.space[j, k].step();
            }
            // хто залишився живий
            for (int j = 0; j < 500; j++)
                for (int k = 0; k < 500; k++)
                    if (military_unit.space[j, k] != null) 
                        Console.WriteLine(j+" "+k+" "+ military_unit.space[j, k].GetName());
            Console.ReadLine();
        }
    }
}
