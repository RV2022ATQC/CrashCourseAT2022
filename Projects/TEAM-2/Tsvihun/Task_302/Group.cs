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
            Console.WriteLine ($"=== GROUP: {Name} ===");
            foreach (Student student in students)
            {
                student.showInfo();
            }
        }

        public void AvgProgress (string subject)
        {

            int studentsAmount = 0;
            double avgMark, summaryMark = 0;

            // Calculate the amount of students and their summary mark for current subject
            foreach (Student student in students)
            {
                if (student.subjects.ContainsKey(subject)) {
                    summaryMark += student.subjects[subject];
                    studentsAmount++;
                }                
            }

            // Show average mark only if students have this subject
            if (studentsAmount > 0)
            {
                avgMark = summaryMark / studentsAmount;
                Console.WriteLine($"--- Average mark in {subject} of \"{Name}\" = {avgMark} ---");
            }
            else { Console.WriteLine($"--- No subject {subject} in \"{Name}\" ---"); }
            
        }

    }
}
