using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task317.Classes;

namespace Task317
{
    class Program
    {
        //Створити абстрактний базовий клас з віртуальною функцією - площа.
        //Створити похідні класи: прямокутник, коло, прямокутний трикутник, трапеція зі своїми функціями площі.
        //Для перевірки визначити масив посилань на абстрактний клас, яким присвоюються адреси різних об'єктів.
        //Площа трапеції: S = (a + b) h / 2
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 7);
            Console.WriteLine($" Rectangle: \n  a = {rect.a}\n  b = {rect.b}\n  square = {rect.square()}\n");

            Circle circle = new Circle(5);
            Console.WriteLine($" Circle: \n  R = {circle.R}\n  square = {Math.Round(circle.square(), 2)}\n");

            Triangle triang = new Triangle(3, 5);
            Console.WriteLine($" Triangle: \n  a = {triang.a}\n  b = {triang.b}\n  square = {triang.square()}\n");

            Trapeze trap = new Trapeze(5, 7, 6);
            Console.WriteLine($" Trapeze: \n  a = {trap.a}\n  b = {trap.b}\n  h = {trap.h}\n  square = {trap.square()}\n");

        }
    }
}
