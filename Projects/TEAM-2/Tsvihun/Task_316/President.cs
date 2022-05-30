using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_316
{
    internal class President : Employee
    {
        string employeeType = "President";
        string responsibilities = "Manage a company. Analyze performance. Appoint managers";

        public President(string name) :base(name) {}

        public override string Type
        {
            get => employeeType;
            set => employeeType = value;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Position: {Type}");
            Console.WriteLine($"Responsibilities: {responsibilities}");
        }
    }
}
