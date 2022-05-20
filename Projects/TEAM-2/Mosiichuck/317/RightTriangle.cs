namespace _317
{
    class RightTriangle:Figure
    {
        public double B { get; set; }
        public RightTriangle(double a, string name, double b) : base(a, name)
        {
            B = b;
        }

        public override double Square()
        {
            return A * B/2;
        }
    }
}
