using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team1_group
{
    class Program
    {
        static void Add_abrams()
        {
            //абрамси спавняться своїй половині дошки відстані 250 одиниць від краю
            Random rnd = new Random();
            //наша армія
            for (int i = 0; i < 10; i++)
            {
                int x = rnd.Next(500), y = rnd.Next(500);
                if (military_unit.space[x, y] == null && x < 250)
                    military_unit.space[x, y] = new abrams(x, y, 20, 30, 100, "0", "Abrams1");
                else
                    i--;
            }
            //ворожа армія
            for (int i = 0; i < 10; i++)
            {
                int x = rnd.Next(500), y = rnd.Next(500);
                if (military_unit.space[x, y] == null && x > 250)
                    military_unit.space[x, y] = new abrams(x, y, 20, 30, 100, "1", "Abrams1");
                else
                    i--;
            }
        }

        static void Add_vilkhas()
        {
            //вільхи спавняться на краях дошки на відстані 100 одиниць
            Random rnd = new Random();
            //наша армія
            for (int i = 0; i < 8; i++)
            {
                int x = rnd.Next(500), y = rnd.Next(500);
                if (military_unit.space[x, y] == null && x < 100)
                    military_unit.space[x, y] = new Vilkha_unit(x, y, 50, 20, 50,"0", "Vilkha");
                else
                    i--;
            }
            //ворожа армія
            for (int i = 0; i < 8; i++)
            {
                int x = rnd.Next(500), y = rnd.Next(500);
                if (military_unit.space[x, y] == null && x >400)
                    military_unit.space[x, y] = new Vilkha_unit(x, y, 50, 20, 50, "1", "Vilkha");
                else
                    i--;
            }
        }
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
            int counterOfFriends = 0;
            int counterOfEnemies = 0;

            //створення одиниць
            Add_abrams();
            Add_vilkhas();

            //загальний ігровий цикл
            for (int i = 0; i < 15; i++)
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
                    {
                        Console.WriteLine($"{j} {k}   {military_unit.space[j, k].GetName()} - health: {military_unit.space[j, k].defense}");
                        if (military_unit.space[j, k].army_name.Equals("0"))
                            counterOfFriends++;
                        else
                            counterOfEnemies++;
                    }
            // оголошення хто виграв
            if (counterOfEnemies > counterOfFriends)
                Console.WriteLine("\nWE LOSE");
            else
            Console.WriteLine("\nWE WIN");
            
            Console.ReadLine();
        }
        
    }
}
