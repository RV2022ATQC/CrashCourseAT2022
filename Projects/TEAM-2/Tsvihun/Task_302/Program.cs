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
            // Create some students
            Student antonio = new Student("Anton", "Tsvihun", 5, 5, 3, 3);
            Student bogdan = new Student("Bogdan", "Kravchuk", 4, 3, 4, 4);
            Student olena = new Student("Olena", "Khavruk", 4, 2, 4, 5);
            Student natali = new Student("Natalia", "Savyuk", 4, 5, 5 ,3);
            Student sasha = new Student("Aleksandr", "Roll", 5, 4, 4, 4);
            Student ira = new Student("Iryna", "Lysyuuk", 3, 4, 3, 5);
            Student valera = new Student("Valeriy", "Cycler", 4, 4, 5, 3);
            Student serg = new Student("Sergiy", "Shnayder", 5, 5, 4, 5);

            // Add students to group
            Group group_1 = new Group("DevOps");
            group_1.AddStudent(antonio);
            group_1.AddStudent(bogdan);
            group_1.AddStudent(olena);
            group_1.AddStudent(natali);


            group_1.ShowStudents();


            // antonio.showInfo();

            //Student teacher = new Student("Anton", "Romanukha", 6);
            //teacher.showInfo();
        }
    }
}
