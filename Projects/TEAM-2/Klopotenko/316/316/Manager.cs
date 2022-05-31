using System;
namespace _316
{
    internal class Manager : Employee
    {
        public string Department;

        public Manager(string Name, string Department) : base (Name)
        {
            this.Department = Department;
            Console.WriteLine($"I'm a new manager of {CompanyName}");
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Type: Manager, Department: {Department}");
        }
    }
}
