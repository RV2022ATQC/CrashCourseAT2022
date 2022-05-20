using System;

namespace _303
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string PhoneNumber { get; set; }
        public Person(string name, int age, string sex, string phoneNumber)
        {
            Name = name;
            Age = age;
            Sex = sex;
            PhoneNumber = phoneNumber;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, age: {Age}, sex: {Sex}, phone: {PhoneNumber}");
        } 

    }
}
