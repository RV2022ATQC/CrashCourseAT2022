using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task314
{
    //Створіть клас Student, який буде містити інформацію про студента.
    //За допомогою механізму наслідування, реалізуйте клас Aspirant
    //(аспірант - студент, який готується до захисту кандидатської роботи) похідний від Student.
    public class Student
    {
        private string name;
        private int age;
        private double averMark;

        public string getName()
        {
            return this.name;
        }
        public void setName(string _name)
        {
            this.name = _name;
        }
        public int getAge()
        {
            return this.age;
        }
        public void setAge(int _age)
        {
            if (_age <= -1)
            {
                this.age = 0;
            }
            else
            {
                this.age = _age;
            }
        }
        public double getMark()
        {
            return this.averMark;
        }
        public void setMark(double _averMark)
        {
            if (_averMark <= 0)
            {
                this.averMark = 1;
            }
            else
            {
                this.averMark = _averMark;
            }
        }

        public Student(string _name, int _age, double _averMark)
        {
            setName(_name);
            setAge(_age);
            setMark(_averMark);
            Console.WriteLine($"  {getName()} is a student!");
        }

        public override string ToString()
        {
            return $"  Name: {getName()}\n  Age: {getAge()}\n  Average mark: {getMark()}\n";
        }
    }
}
