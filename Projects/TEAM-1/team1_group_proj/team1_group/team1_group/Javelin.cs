using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team1_group
{
    class javelin : military_unit
    {
        static float distance = 25;
        static float speed = 25;
        //private float xx,yy;
        public javelin() { }
        public javelin(int _x, int _y, int _ammun, int _defence, int _fuel, string _army_name, string _name)
            : base(_x, _y, _ammun, _defence, _fuel, _army_name)
        {
            name = _name + " " + (_army_name.Equals("1") ? "enemy" : "friend");
            space[_x, _y] = this;
            //x = _x; y = _y;
        }
        //функція руху
        public override void move()
        {//вибір напрямку руху по прямій. відстань-speed
            military_unit.space[x, y] = null;
            Random rnd = new Random();
            //випадковий кут
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
            Random rnd = new Random();
            a.defense -= 10; ;

            // Пошкодження в центрі від 25 до 40 і в радіусі 1 від 15 до 30

            int sideDamage = rnd.Next(15, 30);
            for (int i = -1; i <= 1; i++)
                for (int j = -1; j <= 1; j++)
                {
                    if (a.x + i <= 500 && a.x + i >= 0 && a.y + j <= 500 && a.y + j >= 0)
                        if (military_unit.space[a.x + i, a.y + j] != null)
                        {
                            military_unit.space[a.x + i, a.y + j].defense -= sideDamage;
                            if (military_unit.space[a.x + i, a.y + j].defense <= 0)
                            military_unit.space[a.x + i, a.y + j] = null;
                        }
                }
            if (a.defense <= 0) military_unit.space[a.x, a.y] = null;
            military_unit.space[x,y] = null;
        }
        
        //функція аналізу простору, вибір обєкта для атаки
        //аналізує постір в радіусі distanse та шукає можливий об'єкт для атаки
        public military_unit locator()
        {

            for (int di = -(int)distance + 1; di < distance; di++)
                for (int dj = -(int)distance + 1; dj < distance; dj++)
                    if (di * di + dj * dj < distance * distance &&
                        x + di >= 0 && x + di < 499 && y + dj >= 0 && y + dj < 499)
                        if (military_unit.space[x + di, y + dj] != null &&
                            String.CompareOrdinal(military_unit.space[x + di, y + dj].army_name, army_name) != 0)
                            return military_unit.space[x + di, y + dj];
            return null;

        }
        public override void step()
        {
            military_unit a = locator();
            if (a == null) move(); else attack(a);
        }
        public string getname()
        {
            return name;
        }

    }
}
