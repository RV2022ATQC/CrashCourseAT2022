using System;
namespace _314
{
    public class Student
    {
        public string Name;
        public int Grade;

        public Student(string Name, int Grade)
        {
            this.Name = Name;
            this.Grade = Grade;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Grade: {Grade}");
        }
    }
}
