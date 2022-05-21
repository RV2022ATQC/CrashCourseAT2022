using System;
namespace _317
{
    abstract class Figure
    {
        public double a;
        public double b;
        public double h;

        protected Figure(double a)
        {
            this.a = a;
        }

        public virtual void Square()
        {
            Console.Write("Square of ");
        }
    }
}
