namespace _317
{
    class Rectangle : Figure
    {
        public double B { get; set; }

        public Rectangle(double a, string name, double b) : base(a, name)
        {
            B = b;
        }

        public override double Square()
        {
            return A*B;
        }
    }
}
