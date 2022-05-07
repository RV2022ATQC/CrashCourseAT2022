// 302
// Написати клас Студент. Також реалізувати клас, що описує групу студентів.
// Передбачити можливість визначення середньої успішності групи за певним предметом.
using System;

namespace Task_302
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student antonio = new Student();
            antonio.showInfo();

            Student teacher = new Student("Anton", "Romanukha", 6);
            teacher.showInfo();
        }
    }
}
