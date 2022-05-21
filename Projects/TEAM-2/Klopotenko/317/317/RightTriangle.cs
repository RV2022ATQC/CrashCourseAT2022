using System;
namespace _317
{
    internal class RightTriangle : Figure
    {
        public RightTriangle(double a, double b) : base (a)
        {
            this.b = b;
        }

        public override void Square()
        {
            base.Square();
            double Square = a * b / 2;
            Console.WriteLine($"right triangle is {Square}");
        }
    }
}
