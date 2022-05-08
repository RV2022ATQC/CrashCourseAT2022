using System;
using System.Collections.Generic;
using System.Text;

namespace Task_302
{
    internal class Group
    {

        List<Student> students;
        private string name;
        public string Name { get => name; set => name = value; }

        public Group (string groupName)
        {
            students = new List<Student>();
            Name = groupName;
        }

       public void AddStudent (Student student)
        {
            students.Add(student);
        }

        public void ShowStudents ()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student);
                //student.showInfo();
            }
        }

    }
}
