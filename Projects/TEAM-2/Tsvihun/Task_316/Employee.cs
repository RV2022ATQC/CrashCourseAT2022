using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_316
{
    abstract class Employee
    {

        public const string COMPANY_NAME = "FUSION INDUSTRIES LLC";
        public string Name { get; }
        public abstract string Type { get; set; }

        public Employee(string name) 
        {
            Name = name;
            Console.WriteLine($"----- I work at {COMPANY_NAME} -----");
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}. ");
        }
    }
}
