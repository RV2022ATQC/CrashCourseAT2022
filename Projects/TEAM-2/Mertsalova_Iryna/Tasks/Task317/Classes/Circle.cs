using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task317.Classes
{
    public class Circle : Figure
    {
        public int R { get; set; }
        public Circle(int _R)
        {
            this.R = _R;
        }
        public override double square()
        {
            return Math.PI * Math.Pow(R, 2);
        }
    }
}
