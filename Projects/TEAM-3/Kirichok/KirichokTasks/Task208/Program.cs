using System;
//3. Відомо, що 1 дюйм дорівнює 2.54 см. Розробити додаток, що переводять дюйми в сантиметри і навпаки.
// Діалог з користувачем реалізувати через систему меню.
namespace Task208
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double inch_in_sm = 2.54;
            double len;
            Console.WriteLine("Оберiть завдання: \n1 - дюйми => см\n2 - см => дюйми");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Кiлькiсть дюймiв: ");
                    len = double.Parse(Console.ReadLine());
                    Console.WriteLine("см = {0}", len * inch_in_sm);
                    break;
                case 2:
                    Console.Write("Кiлькiсть см: ");
                    len = double.Parse(Console.ReadLine());
                    Console.WriteLine("дюймiв = {0}", len * (1 / inch_in_sm));
                    break;
                default:
                    Console.WriteLine("Оберіть 1 або 2");
                    break;
            }
            Console.ReadKey();
        }
    }
}
