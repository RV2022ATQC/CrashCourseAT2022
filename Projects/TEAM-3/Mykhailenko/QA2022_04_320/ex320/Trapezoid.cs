using System;

namespace ex320
{
    public class Trapezoid : Figure
    {
        double base_big;
        double base_small;
        double height;

        public double Base_Big { get { return base_big; } set { base_big = value; } }
        public double Base_Small { get { return base_small; } set { base_small = value; } }
        public double Height { get { return height; } set { height = value; } } 
  
        public Trapezoid() // for add any figure
        {
            this.base_big = 0;
            this.base_small = 0;
            this.height = 0;
            this.square = GetSquare();
        }
        public Trapezoid(string _name, w_color _color, DateTime _date, double _base_big, double base_small, double _height) : base(_name, _color, _date)
        {
            this.base_big = _base_big;
            this.base_small = base_small;
            this.height = _height;
            this.square = GetSquare();
                
        }
        public override double GetSquare()
        {
            return (base_big+base_small)*height/2;
        }

        public override void Input()
        {
            try 
            {
                this.input_figure();
                Console.Write("Input base big   : ");
                try { this.base_big = double.Parse(Console.ReadLine()); }
                catch (Exception ex) { this.base_big = 0; }
                
                Console.Write("Input base small : ");
                try { this.base_small = double.Parse(Console.ReadLine()); }
                catch (Exception ex) { this.base_small = 0; }

                Console.Write("Input height     : ");
                try { this.height = double.Parse(Console.ReadLine()); }
                catch(Exception ex) { this.height = 0; }
                
                this.square = GetSquare();
            }
            catch (Exception e) { Console.WriteLine(e); }
        }

        public new string GetShape()
        {
            return base.GetShape() + $"Base big         : {base_big}\nBase small       : {base_small}\nHeight           : {height}\nSquare           : {square}"; 
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
