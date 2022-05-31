using System;

namespace _316
{
    class Program
    {
        //Створити абстрактний базовий клас Employer (службовець) з віртуальною функцією Print ().
        //Створіть три класи нащадки: President, Manager, Worker.
        //Перевизначите функцію Print () для виведення інформації, що відповідає кожному типу службовця.
        static void Main(string[] args)
        {
            President president = new President("Stephan Rally", 40, 45000, "Ford and room");
            president.Print();

            Console.WriteLine();
            Manager manager = new Manager("Olga Vinston", 31, 1200, 1);
            manager.Print();

            Console.WriteLine();
            Worker worker = new Worker("Olha Vurdalak", 50, 500, "juwelery");
            worker.Print();
        }
    }
}
