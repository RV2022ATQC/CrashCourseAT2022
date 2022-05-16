using System;
using _302;

class Program
{
    public static void Main(string[] args)
    {
        //First Student
        List<Subject> subjects = new List<Subject>();
        List<int> marks_subject1 = new List<int>() { 5, 7, 9, 11 };
        subjects.Add(new Subject("subject1", marks_subject1));


        List<int> marks_subject2 = new List<int>() { 8, 9, 6, 5 };
        subjects.Add(new Subject("subject2", marks_subject2));

        List<int> marks_subject3 = new List<int>() { 8, 11, 10, 9 };
        subjects.Add(new Subject("subject3", marks_subject3));

        Student student1 = new Student("Name1");
        student1.Subjects = subjects;


        //Second Student
        subjects.Clear();
        List<int> marks_subject4 = new List<int>() { 1, 7 };
        subjects.Add(new Subject("subject1", marks_subject4));

        List<int> marks_subject5 = new List<int>() { 12, 6, 8, 9 };
        subjects.Add(new Subject("subject2", marks_subject5));

        List<int> marks_subject6 = new List<int>() { 11, 6, 7 };
        subjects.Add(new Subject("subject3", marks_subject6));

        Student student2 = new Student("Name2");
        student2.Subjects = subjects;



        //Third Student
        subjects.Clear();
        List<int> marks_subject7 = new List<int>() { 4, 6, 8 };
        subjects.Add(new Subject("subject1", marks_subject7));

        List<int> marks_subject8 = new List<int>() { 7, 9, 11 };
        subjects.Add(new Subject("subject2", marks_subject8));

        List<int> marks_subject9 = new List<int>() { 10, 7, 6 };
        subjects.Add(new Subject("subject3", marks_subject9));

        Student student3 = new Student("Name3");
        student3.Subjects = subjects;




        Group group1 = new Group("Group1");
        group1.Students.Add(student1);
        group1.Students.Add(student2);
        group1.Students.Add(student3);

        Console.WriteLine("Average for subject1: " + group1.GetAverageMark("subject1"));
    }
}