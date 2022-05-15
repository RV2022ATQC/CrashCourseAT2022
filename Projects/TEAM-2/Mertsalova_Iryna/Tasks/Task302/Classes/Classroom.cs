using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task302.Classes
{
    public class Classroom
    {
        private List<Student> students;

        public List<Student> getStudents()
        {
            return students;
        }

        public Classroom()
        {
            students = new List<Student>();
        }

        public void addStudent(Student st)
        {
            students.Add(st);
        }

        public void calcAverageMarks()
        {
            int size = students.Count;
            int math = 0, language = 0, chemistry = 0, biology = 0;
            foreach (var item in students)
            {
                math += item.getMath();
                language += item.getLanguage();
                chemistry += item.getChemistry();
                biology += item.getBiology();
            }
            Console.WriteLine("  Average mark in math: " + (float)math / size +
                "\n  Average mark in language: " + (float)language / size +
                "\n  Average mark in chemistry: " + (float)chemistry / size +
                "\n  Average mark in biology: " + (float)biology / size + "\n");
        }

        public void printList()
        {
            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(" -----------------------------------------------------------");
        }
    }
}
