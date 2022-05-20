using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _316
{
    class Manager:Employer
    {
        public int WorkplaceNumber { get; set; }
        public Manager(string name, int age, int sallary, int workplaceNumber) : base(name, age, sallary)
        {
            WorkplaceNumber = workplaceNumber;
        }

        public override void Print()
        {
            base.Print();
            Console.Write("workplace number is " + WorkplaceNumber);
            Console.WriteLine();
        }
    }
}
