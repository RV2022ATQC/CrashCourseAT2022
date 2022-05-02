/*
Реалізуйте клас наслідник Rectangle, який має додаткові поля Height, Width. Конструктор з параметрами, додаткові getters та setters. Overridden input() та output()
*/

using System;

namespace ex320
{
    public class Rectangle : Figure
    {
        double height;
        double width;

        public double Height { get { return height; }  set { height = value; } }
        public double Width { get { return width; } set { width = value; } }

        public Rectangle() // for add any figure
        {
            this.height = 0;
            this.width = 0;
            this.square = GetSquare();
        }
        public Rectangle (string _name, w_color _color, DateTime _date, double _height, double _width) : base(_name, _color, _date)
        {
            this.height = _height;
            this.width = _width;
            this.square = GetSquare();
        }

        public override double GetSquare() { return this.height * this.width; }

        public new string GetShape()
        {
            return base.GetShape() + $"Height           : { height}\nWidth            : { width}\nSquare           : { square}";
        }

        public override string ToString()
        {
            return GetShape();
        }

        public override void Input()
        {
            try
            {
                this.input_figure();

                Console.Write("Input width      : ");
                try { this.width = double.Parse(Console.ReadLine()); }
                catch (Exception ex) { this.width = 0;  }
                
                Console.Write("Input height     : ");
                try { this.height = double.Parse(Console.ReadLine()); }
                catch (Exception ex) { this.height = 0;  }
                
                this.square = GetSquare();
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        public override void Output()
        {
            Console.WriteLine(GetShape());
        }
    }
}
