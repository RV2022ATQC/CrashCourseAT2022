using System;
using System.Collections.Generic;
using System.Linq;

namespace _302
{
    public class University
    {
        List<Student> student = new List<Student>();
        public void AddStudent(string Name, int Course, int GradeMathematics, int GradePhysics, int GradePE)
        {
            bool isExist = true;
            for (int i = 0; i < student.Count; i++)
            {
                if (Name == student[i].Name)
                {
                    Console.WriteLine($"Student {Name} is already exist!");
                    isExist = false;
                    break;
                }
            }
            if (isExist)
            {
                student.Add(new Student(Name, Course, GradeMathematics, GradePhysics, GradePE));
            }
        }
        public void ShowCourse(int Course)
        {
            int Students = 0;
            for (int i = 0; i < student.Count; i++)
            {
                if (student[i].Course == Course)
                {
                    Console.WriteLine($"Name: {student[i].Name}, Course: {Course}, Math: {student[i].GradeMathematics}, Physics: {student[i].GradePhysics}, PE: {student[i].GradePE}");
                    Students++;
                }
            }
            if (Students == 0)
            {
                Console.WriteLine("No students on this course!");
            }

        }
        public void ShowAverageSuccess(int Course, string Subject)
        {
            var CourseList = from s in student
                             where s.Course == Course
                             select s.GradeMathematics;
            if (Subject == "Physics")
            {
                CourseList = from s in student
                             where s.Course == Course
                             select s.GradePhysics;
            }
            else if (Subject == "PE")
            {
                CourseList = from s in student
                             where s.Course == Course
                             select s.GradePhysics;
            }
            else if (Subject != "Mathematics")
            {
                Console.WriteLine("Not correct subject!");
            }
            if (CourseList.Count() == 0)
            {
                Console.WriteLine("No students on this course!");
            }
            else if (Subject == "Mathematics" || Subject == "Physics" || Subject == "PE")
            {
                double Sum = 0;
                int a = 0;
                foreach (int item in CourseList)
                {
                    Sum += item;
                    a++;
                }
                double Average = Sum / a;
                Console.WriteLine($"The average success from {Subject} of course #{Course} is {Average}");
            }
        }
    }
}