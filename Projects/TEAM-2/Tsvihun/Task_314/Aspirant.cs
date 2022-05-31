using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_314
{
    internal class Aspirant : Student
    {
        public string Degree { get; set; }

        public Aspirant(string name, int grade, string degree) :base(name,grade)
        {
            Degree = degree;
            Console.WriteLine("I'm a graduate student.");
        }

        public new void StudentInfo()
        {
            Console.WriteLine($"{base.Name}, {base.Grade} grade. Degree: {Degree}");
        }
    }
}
