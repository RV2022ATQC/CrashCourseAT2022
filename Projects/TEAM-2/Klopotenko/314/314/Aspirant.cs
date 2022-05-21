using System;
namespace _314
{
    public class Aspirant : Student
    {
        public string Degree;
        public Aspirant(string Name, int Grade, string Degree) : base(Name, Grade)
        {
            this.Degree = Degree;
            Console.WriteLine("I'm aspirant!");
        }

        public new void ShowInfo()
        {
            Console.WriteLine($"Name: {base.Name}, Grade: {base.Grade}, Degree: {Degree}");
        }
    }
}
