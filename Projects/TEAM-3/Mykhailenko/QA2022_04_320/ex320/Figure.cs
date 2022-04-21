/*
Опишіть клас Геометричні фігури, який містить поля:
Площа, Колір, Дата створення, назву
конструктор з параметрами
функції консольного введення та виведення полів
Getteres Setters
Метод GetCreatedDate() що виводить повні дні від створення
overridden ToString() метод, який викликає метод GetShape()
*/

using System;

namespace ex320
{
    public enum w_color
    {
        grey,
        silver,
        black,
        green,
        blue,
        white,
        red,
        yellow
    }
    public abstract class Figure
    {
        protected string name;
        protected w_color color;
        protected DateTime datecreate;
        protected double square;

        public string Name { get { return name; } set { name = value; } }
        public w_color Color { get { return color; } set { color = value; } }
        public DateTime DateCreate { get { return datecreate; } set { datecreate = value; } }

        public Figure() // for add any figure
        {
            this.name = "";
            this.color = w_color.black;
            this.datecreate = DateTime.Now;
            this.square = GetSquare();
        }

        public Figure(string _name, w_color _color, DateTime _date) 
        {
            this.name = _name;
            this.color = _color;
            this.datecreate = _date;
            this.square = GetSquare();
        }

        public int GetCreateDate() { return (int)Math.Floor((DateTime.Now - this.datecreate).TotalDays); }

        public string GetShape()
        {
            return $"Name             : {this.Name}\nColor            : {this.Color}\nDate             : {this.DateCreate.ToShortDateString()}\nDiff days        : {this.GetCreateDate()}\n";
        }

        protected void input_figure()
        {
            int t_day = 0;
            int t_month = 0;
            int t_year = 0;
            try
            {
                Console.Write("Input name of figure : "); this.name = Console.ReadLine();
                Console.Write("Input color of figure (");
                foreach (string item in Enum.GetNames(typeof(w_color))) { Console.Write($"{item} "); }
                Console.Write("default color = black) : ");
                string tmp_color = Console.ReadLine();
                switch (tmp_color.ToLower())
                {
                    case "grey": this.color = w_color.grey; break;
                    case "silver": this.color = w_color.silver; break;
                    case "black": this.color = w_color.black; break;
                    case "green": this.color = w_color.green; break;
                    case "blue": this.color = w_color.blue; break;
                    case "white": this.color = w_color.white; break;
                    case "red": this.color = w_color.red; break;
                    case "yellow": this.color = w_color.yellow; break;
                    default: this.color = w_color.black; break;
                }
                Console.Write("Input create date of figure\nDay              : ");
                try { t_day = int.Parse(Console.ReadLine()); }
                catch (Exception ex) { t_day = 0; }
                finally { if (t_day <= 0) { t_day = 1; } }
                
                Console.Write("Month            : ");
                try { t_month = int.Parse(Console.ReadLine()); }
                catch (Exception ex) { t_month = 0; }
                finally { if (t_month <= 0) { t_month = 1; } }
                
                Console.Write("Year             : ");
                try { t_year = int.Parse(Console.ReadLine()); }
                catch(Exception ex) { t_year = 0; }
                finally { if (t_year <= 0) { t_year = 1; } }

                DateTime t_date = new DateTime(t_year, t_month, t_day);
                this.datecreate = t_date;
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public abstract void Input();
        public abstract void Output();  
        public abstract double GetSquare();
     }
}