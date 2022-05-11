using System;
using System.Collections.Generic;
using System.Linq;

namespace _302
{
    public class Group
    {
        List<Student> students;
        private string Name;
        public Group(string groupName)
        {
            students = new List<Student>();
            Name = groupName;
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void ShowStudents()
        {
            Console.WriteLine($"Group {Name}: ");
            foreach (Student student in students)
            {
                student.showStudent();
            }
        }
        public void ShowAverageSuccess (string subject)
        {
            int studentsAmount = 0;
            double sum = 0;
            foreach (Student student in students)
            {
                if (student.subjects.ContainsKey(subject))
                {
                    sum += student.subjects[subject];
                    studentsAmount++;
                }
            }
            if (studentsAmount > 0)
            {
                double AverageSuccess = sum / studentsAmount;
                Console.WriteLine($"Average mark in {subject} of {Name} = {AverageSuccess}");
            }
            else
            {
                Console.WriteLine($"No subject {subject} in {Name}");
            }
        }
    }
}