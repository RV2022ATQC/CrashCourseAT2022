namespace _317
{
    class Circle : Figure
    {
        public Circle(double a, string name) : base(a, name)
        {
        }

        public override double Square()
        {
            return 3.14 * A * A;
        }
    }
}
