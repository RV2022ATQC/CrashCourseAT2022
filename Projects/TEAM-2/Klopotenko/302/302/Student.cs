using System;
using System.Collections.Generic;

namespace _302
{
    public class Student
    {
        public string Name;
        public Dictionary<string, int> subjects;

        public void showStudent()
        {
            Console.Write($"Name: {Name}. ");
            foreach (var subject in subjects)
            {
                Console.Write($"{subject.Key} - {subject.Value} ");
            }
            Console.WriteLine();
        }

        public Student(string Name, int Math, int Physics, int PE)
        {
            this.Name = Name;
            subjects = new Dictionary<string, int>();
            subjects.Add("Math", Math);
            subjects.Add("Physics", Physics);
            subjects.Add("PE", PE);
        }
    }
}
