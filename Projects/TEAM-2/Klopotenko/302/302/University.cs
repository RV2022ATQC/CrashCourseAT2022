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

        public void ShowAverageSuccessMathematics(int Course)
        {

            var CourseList = from s in student
                             where s.Course == Course
                             select s.GradeMathematics;
            if (CourseList.Count() == 0)
            {
                Console.WriteLine("No students on this course!");
            }
            else
            {
                double SumMath = 0;
                int a = 0;
                foreach (int item in CourseList)
                {
                    SumMath += item;
                    a++;
                }
                double AverageMath = SumMath / a;
                Console.WriteLine($"The average success from Math of course #{Course} is {AverageMath}");
            }
        }

        public void ShowAverageSuccessPhysics(int Course)
        {
            var CourseList = from s in student
                             where s.Course == Course
                             select s.GradePhysics;
            if (CourseList.Count() == 0)
            {
                Console.WriteLine("No students on this course!");
            }
            else
            {
                double SumPhysics = 0;
                int a = 0;
                foreach (int item in CourseList)
                {
                    SumPhysics += item;
                    a++;
                }
                double AveragePhysics = SumPhysics / a;
                Console.WriteLine($"The average success from Physics of course #{Course} is {AveragePhysics}");
            }
        }

        public void ShowAverageSuccessPE(int Course)
        {

            var CourseList = from s in student
                             where s.Course == Course
                             select s.GradePE;
            if (CourseList.Count() == 0)
            {
                Console.WriteLine("No students on this course!");
            }
            else
            {
                double SumPE = 0;
                int a = 0;
                foreach (int item in CourseList)
                {
                    SumPE += item;
                    a++;
                }
                double AveragePE = SumPE / a;
                Console.WriteLine($"The average success from PE of course #{Course} is {AveragePE}");
            }
        }
    }
}