using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task317.Classes
{
    public class Trapeze : Figure
    { //S = (a + b) h / 2
        public int a { get; set; }
        public int b { get; set; }
        public int h { get; set; }
        public Trapeze(int _a, int _b, int _h)
        {
            this.a = _a;
            this.b = _b;
            this.h = _h;
        }
        public override double square()
        {
            return ((a + b) / 2) * h;
        }
    }
}
