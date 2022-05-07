using System;
using System.Collections.Generic;
using System.Text;

namespace Task_302
{
    internal class Group
    {

        List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

    }
}
