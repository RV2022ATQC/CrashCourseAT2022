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
            Group university = new Group();
            university.AddStudent("Klopotenko Vladyslav", 5, 4, 3);
            university.AddStudent("Ivanov Ivan", 3, 1, 5);
            university.AddStudent("Briksa Olga", 4, 2, 5);
            university.AddStudent("Umanow Maksim", 5, 4, 3);
            university.AddStudent("Sergiev Bodia", 5, 1, 3);
            university.AddStudent("Velomyr Vladimir", 5, 4, 3);
            university.AddStudent("Rostemon Yurii", 5, 4, 3);
            university.AddStudent("Valentinov Ivan", 1, 1, 3);
            university.AddStudent("Danskii David", 5, 5, 5);

            university.ShowGroup();
            Console.WriteLine();

            university.ShowAverageSuccess("PE");
            Console.WriteLine();
            university.ShowAverageSuccess("Mathematics");
            Console.WriteLine();
            university.ShowAverageSuccess("Physics");
            Console.WriteLine();
            university.ShowAverageSuccess("111");
            Console.WriteLine();
        }
    }
}