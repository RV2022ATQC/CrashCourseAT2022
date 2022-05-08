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
            Student antonio = new Student("Anton", "Tsvihun", 1);
            Student bogdan = new Student("Bogdan", "Kravchuk", 1);
            Student olena= new Student("Olena", "Khavruk", 2);
            Student natali = new Student("Natalia", "Savyuk", 4);
            Student sasha = new Student("Aleksandr", "Roll", 5);
            Student ira= new Student("Iryna", "Lysyuuk", 3);
            Student valera= new Student("Valeriy", "Cycler", 4);
            Student serg= new Student("Sergiy", "Shnayder", 5);

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
