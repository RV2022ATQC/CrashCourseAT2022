using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _316
{
    class Worker : Employer
    {
        public string Department { get; set; }
        public Worker(string name, int age, int sallary, string department) : base(name, age, sallary)
        {
            Department = department;
        }
        public override void Print()
        {
            base.Print();
            Console.Write("works in deparment " + Department);
            Console.WriteLine();

        }
    }
}
