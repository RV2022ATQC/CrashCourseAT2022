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
                    military_unit.space[x, y] = new Vilkha_unit(x, y, 50, 20, 50, "0", "Vilkha");
                else
                    i--;
            }
            //ворожа армія
            for (int i = 0; i < 8; i++)
            {
                int x = rnd.Next(500), y = rnd.Next(500);
                if (military_unit.space[x, y] == null && x > 400)
                    military_unit.space[x, y] = new Vilkha_unit(x, y, 50, 20, 50, "1", "Vilkha");
                else
                    i--;
            }
        }

        static void Add_railguns()
        {
            //рейлгани приблизно формують другу лінію атаки, від 100 до 200 клітинок
            Random rnd = new Random();
            //союзні рейлгани
            for (int i = 0; i < 4; i++)
            {
                int x = rnd.Next(500), y = rnd.Next(500);
                if (military_unit.space[x, y] == null && x > 100 && x < 200)
                    military_unit.space[x, y] = new railgun_unit(x, y, 5, 50, 50, "0", "Railgun");
                else
                    i--;
            }
            //ворожі рейлгани
            for (int i = 0; i < 4; i++)
            {
                int x = rnd.Next(500), y = rnd.Next(500);
                if (military_unit.space[x, y] == null && x < 400 && x > 300)
                    military_unit.space[x, y] = new railgun_unit(x, y, 5, 50, 50, "1", "Railgun");
                else
                    i--;
            }
        }

        static void Add_spekas()
        {
            //спеки з'являються на відстані 200 одиниць від країв
            Random rnd = new Random();
            //союзні спеки
            for (int i = 0; i < 6; i++)
            {
                int x = rnd.Next(500), y = rnd.Next(500);
                if (military_unit.space[x, y] == null && x < 200)
                {
                    military_unit.space[x, y] = new Speka_unit(x, y, 30, 60, 100, "0", "Speka");
                }

                else
                    i--;
            }
            //ворожі спеки
            for (int i = 0; i < 6; i++)
            {
                int x = rnd.Next(500), y = rnd.Next(500);
                if (military_unit.space[x, y] == null && x > 200)
                {
                    military_unit.space[x, y] = new Speka_unit(x, y, 30, 60, 100, "1", "Speka");
                }

                else
                    i--;
            }
        }
        static void Add_javelins()
        {
            //джавеліни спавняться своїй половині дошки відстані 175-225 одиниць від краю за абрамсами
            Random rnd = new Random();
            //наша армія
            for (int i = 0; i < 7; i++)
            {
                int x = rnd.Next(500), y = rnd.Next(500);
                if (military_unit.space[x, y] == null && (x > 175 || x < 225))
                    military_unit.space[x, y] = new javelin(x, y, 1, 10, 500, "0", "javelin");
                else
                    i--;
            }
            //ворожа армія
            for (int i = 0; i < 7; i++)
            {
                int x = rnd.Next(500), y = rnd.Next(500);
                if (military_unit.space[x, y] == null && (x > 275 || x < 325))
                    military_unit.space[x, y] = new javelin(x, y, 1, 10, 500, "1", "javelin");
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
            Add_railguns();
            Add_spekas();

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
