using System;
using System.Collections.Generic;
using System.Text;

namespace Task_302
{
    internal class Student
    {
        string firstName;
        string lastName;
        int grade;

        public Student() { Console.WriteLine("New student created !"); }
        public Student(string firstName, string lastName, int grade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.grade = grade;
        }

        public void showInfo()
        {
            Console.WriteLine($"Name: {firstName} {lastName}\nGrade: {grade}");
        }

    }
}
