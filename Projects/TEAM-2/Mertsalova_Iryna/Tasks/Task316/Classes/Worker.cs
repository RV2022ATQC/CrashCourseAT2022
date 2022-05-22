using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task316.Classes
{
    public class Worker : Employee
    {
        private string typeOfWork;
        public string getTypeOfWork() { return this.typeOfWork; }
        public void setTypeOfWork(string _type) { this.typeOfWork = _type; }
        public Worker(string _name, int _age, int day, int month, int year, int _salary, string _type) : base(_name, _age, day, month, year, _salary)
        {
            setTypeOfWork(_type);
        }

        public override void print()
        {
            Console.WriteLine(" Worker:");
            base.print();
            Console.WriteLine($"  Type of work: {getTypeOfWork()}\n");
        }
    }
}
