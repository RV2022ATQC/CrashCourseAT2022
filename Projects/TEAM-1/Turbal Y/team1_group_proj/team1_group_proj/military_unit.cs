using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team1_group
{
    abstract class military_unit
    {
        //ігровий простір
        public static military_unit[,] space = new military_unit[500, 500];
        public string name;
        //координати обєкта
        public int x, y;
        // боєзапас. Для спрощення можемо вважати, що є один базовий тип зброї. Танк-снаряди, літак-ракети і т.п.
        protected int ammunition;
        //стан броні . можемо описувати як число від 0 до 10. 0-death
        protected int defense_level;
        //рівень палива. Кожна реальна одиниця матиме різні витрати на 1 км
        protected int fuel;
        //до якої армії належить 0,1
        public byte army_name;
        public int defense { 
           get {return defense_level;}
            set { defense_level = value; }
                              }
        public military_unit()
        { }
        public military_unit(int _x,int _y,int _ammun, int _defence, int _fuel ,byte _army_name)
        {
            x = _x;
            y = _y;
            ammunition = _ammun;
            defense_level = _defence;
            fuel = _fuel;
            army_name = _army_name;
            // народження об'єкта в точці x,y
            space[x, y] = this;

        }
            //функція руху
            public abstract void move();
            //функція атаки обєкта
            public abstract void attack(military_unit a);
            //функція заправки
            public virtual void refuel(int _n)
        {
            fuel = _n;
        }
            //функція завантаження боєприпасів
            public virtual void armament(int n)
        { ammunition = n; }
            public void sleep()
            { }
        //фнкція ремонту
        public virtual void repair(int _n)
            {
                defense_level = _n;
            }
        }
    }
