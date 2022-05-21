using System;

namespace _316
{
    abstract class Employee
    {
        public const string CompanyName = "AMAZON";
        public string Name;

        public Employee(string Name)
        {
            this.Name = Name;
            Console.Write($"I'm working at {CompanyName}. ");
        }

        public virtual void Print()
        {
            Console.Write($"Company: {CompanyName}, Name: {Name}. ");
        }
    }
}
