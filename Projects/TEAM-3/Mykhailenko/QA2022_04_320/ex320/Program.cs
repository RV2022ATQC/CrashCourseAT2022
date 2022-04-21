/*
* Опишіть клас Геометричні фігури, який містить поля:
Площа, Колір, Дата створення, назву
конструктор з параметрами
функції консольного введення та виведення полів
Getteres Setters
Метод GetCreatedDate() що виводить повні дні від створення
overridden ToString() метод, який викликає метод GetShape()

Реалізуйте клас наслідник Rectangle, який має додаткові поля Height, Width. Конструктор з параметрами, додаткові getters та setters. Overridden input() та output()

Створіть колекцію фігур, додати кілька різних фігур та прямокутників до цієї колекції
реалізуйте виведення фігур, що створені впродовж минулого тижня
виведііть прямокутникі відсортовані за висотою

збережіть колекцію у файл
реалізуйте опрацювання виключень (Exceptions)
сереалізуйте (Serialize) колекцію в XML файл
десереалізуйте колекцію з XML файла
напишіть unit тести до реалізованих функцій
*/

using System;
using System.Collections.Generic;

namespace ex320
{
    internal class Program
    {
        static List<Figure> figures = new List<Figure>();
        static string file_name = "db.xml";
        
        static void Main(string[] args)
        {
            Console.WriteLine("At the beginning of work, the list of figures is empty.\nFill in the list of figures either by selecting menu item 3\nor by entering figures manually, menu item 4.\n");
            UI.Menu(figures, file_name);
        }
    }
}
