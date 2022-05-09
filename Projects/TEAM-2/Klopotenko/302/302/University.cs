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
            var CourseMath = from s in student
                             where s.Course == Course && Subject == "Mathematics"
                             select s.GradeMathematics;
            var CoursePhysics = from s in student
                                where s.Course == Course && Subject == "Physics"
                                select s.GradeMathematics;
            var CoursePE = from s in student
                           where s.Course == Course && Subject == "PE"
                           select s.GradeMathematics;
            if (Subject != "Mathematics" && Subject != "Physics" && Subject != "PE")
            {
                Console.WriteLine("Not correct subject!");
            }
            else if (CourseMath.Count() == 0 && CoursePhysics.Count() == 0 && CoursePE.Count() == 0)
            {
                Console.WriteLine("No students on this course!");
            }
            else
            {
                if (CourseMath.Count() != 0)
                {
                    double Sum = 0;
                    double a = 0;
                    foreach (int item in CourseMath)
                    {
                        Sum += item;
                        a++;
                    }
                    double Average = Sum / a;
                    Console.WriteLine($"The average success from {Subject} of course #{Course} is {Average}"); 
                }
                else if (CoursePhysics.Count() != 0)
                {
                    double Sum = 0;
                    double a = 0;
                    foreach (int item in CoursePhysics)
                    {
                        Sum += item;
                        a++;
                    }
                    double Average = Sum / a;
                    Console.WriteLine($"The average success from {Subject} of course #{Course} is {Average}");
                }
                else
                {
                    double Sum = 0;
                    double a = 0;
                    foreach (int item in CoursePE)
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
}