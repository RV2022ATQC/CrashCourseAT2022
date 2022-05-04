using System;
namespace _302
{
    public class Student
    {
        public string Name;
        public int Course;
        public int GradeMathematics;
        public int GradePhysics;
        public int GradePE;

        public Student(string Name, int Course, int GradeMathematics, int GradePhysics, int GradePE)
        {
            this.Name = Name;
            this.Course = Course;
            this.GradeMathematics = GradeMathematics;
            this.GradePhysics = GradePhysics;
            this.GradePE = GradePE;
        }
    }
}
