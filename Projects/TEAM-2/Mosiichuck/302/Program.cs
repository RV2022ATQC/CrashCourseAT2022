using System;

namespace _302
{
    class Program
    {
        //Написати клас Студент. Також реалізувати клас, що описує групу студентів.
        //Передбачити можливість визначення середньої успішності групи за певним предметом.
        static void Main(string[] args)
        {
            Student student1 = new Student("Valera New", 2, 2, 2);
            Student student2 = new Student("Valera Norm", 10, 11, 9);
            Student student3 = new Student("Olga Silver", 12, 12, 12);

            Group group = new Group("ILR-11");
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);

            Console.WriteLine();
            group.PrintStudents();

            Console.WriteLine();
            Console.Write("Enter subject: ");
            group.AvgMark(Console.ReadLine());
        }
    }
}
