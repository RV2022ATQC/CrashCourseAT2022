using System;
namespace _316
{
    internal class President : Employee
    {
        public string Responsibilities;

        public President(string Name, string Responsibilities) : base (Name)
        {
            this.Responsibilities = Responsibilities;
            Console.WriteLine($"I'm a new president of {CompanyName}");
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Type: President, Responsibilities: {Responsibilities}");
        }
    }
}
