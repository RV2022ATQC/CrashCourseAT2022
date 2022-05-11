using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_303
{
    internal class Person
    {
        string name;
        int age;
        string sex;
        string phone;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Phone { get => phone; set => phone = value; }

        public Person() { }
        public Person(string name, int age, string sex, string phone)
        {
            this.name = name;  
            this.age = age;
            this.sex = sex;
            this.phone = phone;
        }

        public void Print ()
        {
            Console.WriteLine ($"Name: {Name}\nAge: {Age}\nSex: {Sex}\nPhone: {Phone}");
        }
    }
}
