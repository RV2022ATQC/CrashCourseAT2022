using System;
using System.Collections.Generic;
using System.Text;

namespace Task_302
{
    internal class Student
    {
        string firstName;
        string lastName;
        int mathMark, engMark, historyMark, psychoMark;
               
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int MathMark { get => mathMark; set => mathMark = value; }
        public int EngMark { get => engMark; set => engMark = value; }
        public int HistoryMark { get => historyMark; set => historyMark = value; }
        public int PsychoMark { get => psychoMark; set => psychoMark = value; }

        public Student(string firstName, string lastName, int math, int eng, int history, int psychology)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MathMark = math;
            this.EngMark = eng;
            this.HistoryMark = history;
            this.PsychoMark = psychology;
        }

      
        public void showInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}\nMarks: Math {MathMark}; Eng {EngMark}; History {HistoryMark}; Pshycho {PsychoMark}");
        }

    }
}
