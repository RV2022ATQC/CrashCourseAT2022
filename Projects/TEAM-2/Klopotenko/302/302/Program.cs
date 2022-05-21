/* Написати клас Студент. 
 Також реалізувати клас, що описує групу студентів.
 Передбачити можливість визначення середньої успішності групи за певним предметом. */


using System;

namespace _302
{
    class Program
    {
        static void Main(string[] args)
        {
            Student vlad = new Student("Vladyslav Klopotenko", 5, 5, 5);
            Student illia = new Student("Illia Morozov", 1, 5, 4);
            Student olga = new Student("Olga Palamarchuk", 4, 2, 2);
            Student renata = new Student("Renata Olivna", 3, 5, 3);

            Group group_1 = new Group("Group 1");
            group_1.AddStudent(vlad);
            group_1.AddStudent(illia);
            group_1.AddStudent(olga);
            group_1.AddStudent(renata);

            group_1.ShowStudents();
            Console.WriteLine();

            group_1.ShowAverageSuccess("Math");
            group_1.ShowAverageSuccess("Physics");
            group_1.ShowAverageSuccess("Psychology");
            group_1.ShowAverageSuccess("PE");
            group_1.ShowAverageSuccess("English");
        }
    }
}