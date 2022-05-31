using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task316.Classes
{
    public class President : Employee
    {
        private string companyName;
        public string getCompanyName() { return this.companyName; }
        public void setCompanyName(string _company) { this.companyName = _company; }
        public President(string _name, int _age, int day, int month, int year, int _salary, string _company) : base(_name, _age, day, month, year, _salary)
        {
            setCompanyName(_company);
        }

        public override void print()
        {
            Console.WriteLine(" President:");
            base.print();
            Console.WriteLine($"  Company name: {getCompanyName()}\n");
        }
    }
}
