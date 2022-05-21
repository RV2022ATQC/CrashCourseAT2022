using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task302.Classes;

namespace Task302
{
    class Program
    {
        static void Main(string[] args)
        {
            Classroom _class = new Classroom(); 

            Student st1 = new Student(1, "Mertsalova", "Iryna", 4, 5, 4, 4);
            Student st2 = new Student(2, "Doroshenko", "Marina", 5, 3, 4, 5);
            Student st3 = new Student(3, "Lanes", "Olena", 5, 4, 3, 4);

            _class.addStudent(st1);
            _class.addStudent(st2);
            _class.addStudent(st3);

            _class.printList();
            _class.calcAverageMarks();
        }
    }
}
