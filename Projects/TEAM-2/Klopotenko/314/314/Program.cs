using System;

namespace _314
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Vladyslav Klopotenko", 5);
            Student s2 = new Student("Illia Morozov", 3);
            Aspirant s3 = new Aspirant("David Olgov", 5, "Physics");
            Aspirant s4 = new Aspirant("Oleg Nikolaev", 1, "Programing");
            s1.ShowInfo();
            s2.ShowInfo();
            s3.ShowInfo();
            s4.ShowInfo();
        }
    }
}
