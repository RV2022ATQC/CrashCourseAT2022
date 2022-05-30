using System;
using System.Collections.Generic;
using System.Linq;

namespace _302
{
    class Group
    {
        private List<Student> students;
        public string Name { get; set; }
        public Group(string name)
        {
            students = new List<Student>();
            Name = name;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine("Student was added!");
        }

        public void PrintStudents()
        {
            Console.WriteLine("Students in group" + Name + " are: ");
            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void AvgMark(string subject)
        {
            int allMarks = 0;
            if (subject == "prog")
            {
                foreach (var item in students)
                {
                    allMarks += item.Prog;
                }
                Console.WriteLine("Avg mark of group in prog is " + ((double)allMarks / students.Count()));
            }
            else
            {
                if (subject == "ukr")
                {
                    foreach (var item in students)
                    {
                        allMarks += item.Ukr;
                    }
                    Console.WriteLine("Avg mark of group in ukr is " + ((double)allMarks / students.Count()));
                }
                else
                {
                    if (subject == "math")
                    {
                        foreach (var item in students)
                        {
                            allMarks += item.Math;
                        }
                        Console.WriteLine("Avg mark of group in math is " + ((double)allMarks / students.Count()));
                    }
                    else
                    {
                        Console.WriteLine("Wrong subject!");
                    }
                }
            }
        }
    }
}
