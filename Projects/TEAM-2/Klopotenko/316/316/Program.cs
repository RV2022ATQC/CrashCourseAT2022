/* Створити абстрактний базовий клас Employer (службовець) з віртуальною функцією Print (). Створіть три класи нащадки: 
President, Manager, Worker. Перевизначите функцію Print () для виведення інформації, що відповідає кожному типу службовця. */



using System;

namespace _316
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new President ("Vladyslav Klopotenko", "Company management");
            Employee e2 = new Manager("Illia Romanov", "Shipping");
            Employee e3 = new Worker("Lera Podgorska", "Customer Service");
            Console.WriteLine();

            e1.Print();
            e2.Print();
            e3.Print();
        }
    }
}
