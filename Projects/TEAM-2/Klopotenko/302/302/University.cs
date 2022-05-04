using System;
using System.Collections.Generic;

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
            switch (Subject)
            {
                case "Mathematics":
                    double AverageMath;
                    double StudentsMath = 0;
                    double a = 0;
                    for (int i = 0; i < student.Count; i++)
                    {
                        if (student[i].Course == Course)
                        {
                            a += student[i].GradeMathematics;
                            StudentsMath++;
                        }
                    }
                    if (StudentsMath == 0)
                    {
                        Console.WriteLine("No students on this course!");
                        break;
                    }
                    else
                    {
                        AverageMath = a / StudentsMath;
                        Console.WriteLine($"The average success from Mathematics of course #{Course} is {AverageMath}");
                        break;
                    }

                    case "Physics":
                    double AveragePhysics;
                    double StudentsPhysics = 0;
                    double b = 0;
                    for (int i = 0; i < student.Count; i++)
                    {
                        if (student[i].Course == Course)
                        {
                            b += student[i].GradePhysics;
                            StudentsPhysics++;
                        }
                    }
                    if (StudentsPhysics == 0)
                    {
                        Console.WriteLine("No students on this course!");
                        break;
                    }
                    else
                    {
                        AveragePhysics = b / StudentsPhysics;
                        Console.WriteLine($"The average success from Physics of course #{Course} is {AveragePhysics}");
                        break;
                    }

                case "PE":
                    double AveragePE;
                    double StudentsPE = 0;
                    double c = 0;
                    for (int i = 0; i < student.Count; i++)
                    {
                        if (student[i].Course == Course)
                        {
                            c += student[i].GradePE;
                            StudentsPE++;
                        }
                    }
                    if (StudentsPE == 0)
                    {
                        Console.WriteLine("No students on this course!");
                        break;
                    }
                    else
                    {
                        AveragePE = c / StudentsPE;
                        Console.WriteLine($"The average success from PE of course #{Course} is {AveragePE}");
                        break;
                    }

                default:
                    Console.WriteLine("Not correct input!");
                    break;
            }
        }
    }
}
