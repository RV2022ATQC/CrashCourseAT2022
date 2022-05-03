using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team1_group
{
    class abrams : military_unit
    {
        public abrams() { }
        public abrams(int _x, int _y, int _ammun, int _defence, int _fuel, byte _army_name, string _name)
            : base(_x, _y, _ammun, _defence, _fuel, _army_name)
        { name = _name;
            space[_x, _y] = this;
        }
        //функція руху
        public override void move()
        {
            x++;
            y++;
        }
        //функція атаки обєкта
        public override void attack(military_unit a)
        {
            a.defense -= 1;
            if (a.defense == 0) space[a.x, a.y] = null;
        }

        public string getname()
        {
            return name;
        }

    }
}
