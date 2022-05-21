using System;
namespace _317
{
    internal class Circle : Figure
    {
        public Circle(double a) : base (a)
        {
        }

        public override void Square()
        {
            base.Square();
            double Square = 2 * 3.14 * a;
            Console.WriteLine($"circle is {Square}");
        }
    }
}
