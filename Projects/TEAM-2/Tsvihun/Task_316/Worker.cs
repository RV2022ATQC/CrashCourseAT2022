using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_316
{
    internal class Worker : Employee
    {
        string employeeType = "Worker";
        string speciality = "Machine operator";

        public Worker(string name) :base(name) {}

        public override string Type
        {
            get => employeeType;
            set => employeeType = value;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Position: {Type}");
            Console.WriteLine($"Speciality: {speciality}");
        }
    }
}
