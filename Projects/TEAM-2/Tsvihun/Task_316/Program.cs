// 316
// Створити абстрактний базовий клас Employee (службовець) з віртуальною функцією Print ().
// Створіть три класи нащадки: President, Manager, Worker.
// Перевизначите функцію Print () для виведення інформації, що відповідає кожному типу службовця.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_316
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee morozov = new Worker("Ihor Morozov");
            morozov.Print();

            Employee konchuk = new Manager("Mykhaylo Konchuk");
            konchuk.Print();

            Employee evin = new President("Andriy Evin");
            evin.Print();
        }
    }
}
