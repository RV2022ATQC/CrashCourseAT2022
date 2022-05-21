using System;
namespace _317
{
    internal class Rectangle : Figure
    {
        public Rectangle(double a, double b) : base(a)
        {
            this.b = b;
        }

        public override void Square()
        {
            base.Square();
            double Square = a * b;
            Console.WriteLine($"rectangle is {Square}");
        }
    }
}
