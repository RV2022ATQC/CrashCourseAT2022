using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task316.Classes
{
    public class Employee
    {
        private string name;
        private int age;
        private DateTime dateOfBirth;
        private int salary;

        public string getName() { return this.name; }
        public void setName(string _name) { this.name = _name; }
        public int getAge() { return this.age; }
        public void setAge(int _age) { this.age = _age; }
        public string getDateOfBirth() { return $"{this.dateOfBirth.Day}/{this.dateOfBirth.Month}/{this.dateOfBirth.Year}"; }
        public void setDateOfBirth(int day, int month, int year) { this.dateOfBirth = new DateTime(year, month, day); }
        public int getSalary() { return this.salary; }
        public void setSalary(int _salary) { this.salary = _salary; }
        public Employee(string _name, int _age, int day, int month, int year, int _salary)
        {
            setName(_name);
            setAge(_age);
            setDateOfBirth(day, month, year);
            setSalary(_salary);
        }

        public virtual void print()
        {
            Console.WriteLine($"  Name: {getName()}\n  Age: {getAge()}\n  Date of birth: {getDateOfBirth()}\n  Salary: {getSalary()}");
        }
    }
}
