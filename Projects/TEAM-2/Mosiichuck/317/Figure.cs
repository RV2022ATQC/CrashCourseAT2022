namespace _317
{
    abstract class Figure
    {
        public double A { get; set; }
        public string Name { get; set; }

        public Figure(double a, string name)
        {
            A = a;
            Name = name;
        }

        public abstract double Square();

    }
}
