using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task316.Classes;

namespace Task316
{
    class Program
    {
        //Створити абстрактний базовий клас Employer (службовець) з віртуальною функцією Print ().
        //Створіть три класи нащадки: President, Manager, Worker.
        //Перевизначите функцію Print () для виведення інформації, що відповідає кожному типу службовця.
        static void Main(string[] args)
        {
            President president = new President("Oleg", 30, 22, 04, 1991, 20000, "Volvo");
            Manager manager = new Manager("Galina", 20, 10, 11, 2002, 15000, "Planning");
            Worker worker = new Worker("Illia", 22, 06, 07, 2000, 12000, "Policeman");
            president.print();
            manager.print();
            worker.print();
        }
    }
}
