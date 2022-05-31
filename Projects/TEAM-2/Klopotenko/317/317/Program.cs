/* Створити абстрактний базовий клас з віртуальною функцією - площа. Створити похідні класи: прямокутник, коло, прямокутний трикутник, трапеція зі своїми функціями площі. 
 * Для перевірки визначити масив посилань на абстрактний клас, яким присвоюються адреси різних об'єктів. Площа трапеції: S = (a + b) h / 2 */


using System;

namespace _317
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures = { new Circle(9.1), new Rectangle(5, 10.5), new RightTriangle(2, 5.5), new Trapeze(5, 10, 2) };
            foreach (var figure in figures)
            {
                figure.Square();
            }
        }
    }
}
