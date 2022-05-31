using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task317.Classes
{
    public class Rectangle : Figure
    {
        public int a { get; set; }
        public int b { get; set; }
        public Rectangle(int _a, int _b)
        {
            this.a = _a;
            this.b = _b;
        }
        public override double square()
        {
            return a * b;
        }
    }
}
