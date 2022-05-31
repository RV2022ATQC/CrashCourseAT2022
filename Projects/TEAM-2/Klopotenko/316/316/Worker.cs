using System;
namespace _316
{
    internal class Worker : Employee
    {
        public string Speciality;
        public Worker(string Name, string Speciality) : base (Name)
        {
            this.Speciality = Speciality;
            Console.WriteLine($"I'm a new worker of {CompanyName}");
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Type: Worker, Speciality: {Speciality}");
        }
    }
}
