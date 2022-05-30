namespace _317
{
    class Trapezoid : Figure
    {
        public double B { get; set; }
        public double H { get; set; }

        public Trapezoid(double a, string name, double h, double b) : base(a, name)
        {
            H = h;
            B = b;
        }

        public override double Square()
        {
            return (A+B) * H/2;
        }
    }
}
