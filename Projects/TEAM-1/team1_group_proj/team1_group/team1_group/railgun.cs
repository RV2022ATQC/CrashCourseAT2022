using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team1_group
{
    class railgun_unit : military_unit
    {
        static float distance = 100;
        static float speed = 15;
        public railgun_unit() { }
        public railgun_unit(int _x, int _y, int _ammun, int _defence, int _fuel, string _army_name, string _name)
            : base(_x, _y, _ammun, _defence, _fuel, _army_name)
        {
            name = _name + " " + (_army_name.Equals("1") ? "enemy" : "friend");
            space[_x, _y] = this;
        }
        public override void move()
        {
            military_unit.space[x, y] = null;
            Random rnd = new Random();
            double fi, _x, _y;
            do
            {
                fi = 2 * Math.PI * rnd.Next() / int.MaxValue;
                _x = x + speed * Math.Cos(fi);
                _y = y + speed * Math.Sin(fi);
            }
            while (!(_x >= 0 && _x <= 500 && _y >= 0 && _y <= 500));
            x = (int)_x;
            y = (int)_y;
            military_unit.space[x, y] = this;
        }

        public override void attack(military_unit a)
        {
            a.defense -= 99;
            if (a.defense <= 0) military_unit.space[a.x, a.y] = null;
        }
        //функція аналізу простору, вибір обєкта для атаки
        //аналізує постір в радіусі distanse та шукає можливий об'єкт для атаки, побачити ворога може тільки по вертикалі або горизонталі
        public military_unit locator()
        {

            for (int di = -(int)distance + 1; di < distance; di++)
                for (int dj = -(int)distance + 1; dj < distance; dj++)
                    if (di * di + dj * dj < distance * distance &&
                        x + di >= 0 && x + di < 499 && y + dj >= 0 && y + dj < 499 && (di == 0 || dj == 0))
                        if (military_unit.space[x + di, y + dj] != null &&
                            String.CompareOrdinal(military_unit.space[x + di, y + dj].army_name, army_name) != 0)
                            return military_unit.space[x + di, y + dj];
            return null;

        }
        public override void step()
        {
            military_unit a = locator();
            if (a == null) move(); else { attack(a);
                Console.WriteLine("KILLLL!!!");
            }
        }
        public string getname()
        {
            return name;
        }

    }
}
