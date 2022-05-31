using System;

namespace _316
{
    abstract class Employer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Sallary { get; set; }

        public Employer(string name, int age, int sallary)
        {
            Name = name;
            Age = age;
            Sallary = sallary;
        }

        public virtual void Print()
        {
            Console.Write(Name +" is "+Age+" years old, has sallary "+ Sallary+"$ ");
        }
    }
}
