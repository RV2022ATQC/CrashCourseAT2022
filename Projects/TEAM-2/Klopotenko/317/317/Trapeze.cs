using System;
namespace _317
{
    internal class Trapeze : Figure
    {
        public Trapeze(double a, double b, double h) : base(a)
        {
            this.b = b;
            this.h = h;
        }

        public override void Square()
        {
            base.Square();
            double Square = (a + b) * h / 2;
            Console.WriteLine($"trapeze is {Square}");
        }
    }
}
