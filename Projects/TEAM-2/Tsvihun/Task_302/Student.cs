using System;
using System.Collections.Generic;
using System.Text;

namespace Task_302
{
    internal class Student
    {
        string firstName;
        string lastName;
        public Dictionary<string, int> subjects;
               
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
 

        public Student(string firstName, string lastName, int math, int eng, int history, int psychology)
        {
            this.FirstName = firstName;
            this.LastName = lastName;

            subjects = new Dictionary<string, int>();
            subjects.Add("Math", math);
            subjects.Add("English", eng);
            subjects.Add("History", history);
            subjects.Add("Psychology", psychology);
        }
      
        public void showInfo()
        {
            Console.Write($"Name: {FirstName} {LastName}. ");
            foreach (var subject in subjects)
            {
                Console.Write($"{subject.Key} - {subject.Value} ");
            }
            Console.WriteLine();
        }

    }
}
