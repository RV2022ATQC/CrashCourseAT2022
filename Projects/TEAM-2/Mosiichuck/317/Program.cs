using System;

namespace _317
{
    class Program
    {
        //Створити абстрактний базовий клас з віртуальною функцією - площа. Створити похідні класи:
        //прямокутник, коло, прямокутний трикутник, трапеція зі своїми функціями площі.
        //Для перевірки визначити масив посилань на абстрактний клас, яким присвоюються
        //адреси різних об'єктів. Площа трапеції: S = (a + b) h / 2
        static void Main(string[] args)
        {
            Figure[] figures = {new Circle(4,"circle"),
                                   new Rectangle(5,"rectangle",8),
                                   new RightTriangle(3,"right triangle",4),
                                   new Trapezoid(10,"trapezoid",6,4) };

            foreach (var item in figures)
            {
                Console.WriteLine("Squre of "+item.Name+" is "+item.Square());
            }
        }
    }
}
