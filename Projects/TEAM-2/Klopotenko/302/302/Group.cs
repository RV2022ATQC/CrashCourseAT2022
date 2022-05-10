using System;
using System.Collections.Generic;
using System.Linq;

namespace _302
{
    public class Group
    {
        List<Student> student = new List<Student>();
        public void AddStudent(string Name, int GradeMathematics, int GradePhysics, int GradePE)
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
                student.Add(new Student(Name, GradeMathematics, GradePhysics, GradePE));
            }
        }
        public void ShowGroup()
        {
            int Students = 0;
            for (int i = 0; i < student.Count; i++)
            {
                Console.WriteLine($"Name: {student[i].Name}, Math: {student[i].GradeMathematics}, Physics: {student[i].GradePhysics}, PE: {student[i].GradePE}");
                Students++;
            }
            if (Students == 0)
            {
                Console.WriteLine("No students in this group!");
            }

        }
        public void ShowAverageSuccess(string Subject)
        {
            switch (Subject)
            {
                case "Mathematics":
                    double a = 0;
                    double Sum = 0; 
                    for (int i = 0; i < student.Count; i++)
                    {
                        a += student[i].GradeMathematics;
                        Sum++;
                    }
                    double result = a / Sum;
                    Console.WriteLine($"The average success from Math of group is {result}");
                    break;

                case "Physics":
                    double b = 0;
                    double Sum1 = 0;
                    for (int i = 0; i < student.Count; i++)
                    {
                        b += student[i].GradePhysics;
                        Sum1++;
                    }
                    double result1 = b / Sum1;
                    Console.WriteLine($"The average success of Physics group is {result1}");
                    break;

                case "PE":
                    double c = 0;
                    double Sum2 = 0;
                    for (int i = 0; i < student.Count; i++)
                    {
                        c += student[i].GradeMathematics;
                        Sum2++;
                    }
                    double result2 = c / Sum2;
                    Console.WriteLine($"The average success from PE of group is {result2}");
                    break;

                default:
                    Console.WriteLine("Not correct subject!");
                    break;
            }
        }
    }
}