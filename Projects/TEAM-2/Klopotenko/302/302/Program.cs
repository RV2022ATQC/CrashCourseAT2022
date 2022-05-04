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
            University university = new University();
            university.AddStudent("Klopotenko Vladyslav", 1, 5, 4, 3);
            university.AddStudent("Ivanov Ivan", 1, 3, 1, 5);
            university.AddStudent("Briksa Olga", 5, 4, 2, 5);
            university.AddStudent("Umanow Maksim", 1, 5, 4, 3);
            university.AddStudent("Sergiev Bodia", 2, 5, 1, 3);
            university.AddStudent("Velomyr Vladimir", 2, 5, 4, 3);
            university.AddStudent("Rostemon Yurii", 5, 5, 4, 3);
            university.AddStudent("Valentinov Ivan", 4, 1, 1, 3);
            university.AddStudent("Danskii David", 4, 5, 5, 5);

            university.ShowCourse(1);
            Console.WriteLine();
            university.ShowCourse(2);
            Console.WriteLine();
            university.ShowCourse(3);
            Console.WriteLine();
            university.ShowCourse(4);
            Console.WriteLine();
            university.ShowCourse(5);
            Console.WriteLine();

            university.ShowAverageSuccess(1, "PE");
            Console.WriteLine();
            university.ShowAverageSuccess(2, "Mathematics");
            Console.WriteLine();
            university.ShowAverageSuccess(3, "Mathematics");
            Console.WriteLine();
            university.ShowAverageSuccess(1, "Physics");
            Console.WriteLine();
            university.ShowAverageSuccess(5, "Philosophy");
        }
    }
}
