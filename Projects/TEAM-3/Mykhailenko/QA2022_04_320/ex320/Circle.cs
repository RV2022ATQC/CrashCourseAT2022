using System;

namespace ex320
{
    public class Circle : Figure
    {
        double radius;

        public double Radius { get { return radius; } set { radius = value; } }
        public Circle() // for add any figure
        {
            this.radius = 0;
            this.square = GetSquare();
        }

        public Circle (string _name, w_color _color, DateTime _date, double _radius) : base (_name, _color, _date)
        {
            this.radius = _radius;
            this.square = GetSquare();
        }
        public override double GetSquare()
        {
            return (Math.PI * this.radius * this.radius);
        }

        public override void Input()
        {
            try
            {
                this.input_figure();
                Console.Write("Input radius     : ");
                try { this.radius = double.Parse(Console.ReadLine()); }
                catch(Exception ex) { this.radius = 0; }
                
                this.square = GetSquare();
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        public new string GetShape()
        { 
            return base.GetShape()+ $"Radius           : {this.radius}\nSquare           : {this.square}"; ;
        }
        public override string ToString()
        {
            return GetShape();
        }

        public override void Output()
        {
            Console.WriteLine(GetShape());
        }
    }
}
