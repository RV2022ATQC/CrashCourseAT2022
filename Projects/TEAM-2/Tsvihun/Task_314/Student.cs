using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_314
{
    internal class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
            Console.WriteLine("I'm a student");
        }

        public void StudentInfo()
        {
            Console.WriteLine($"{Name}, {Grade} grade");
        }
    }
}
