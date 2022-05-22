using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task316.Classes
{
    public class Manager : Employee
    {
        private string typeOfManager;
        public string getTypeOfManager() { return this.typeOfManager; }
        public void setTypeOfManager(string _type) { this.typeOfManager = _type; }
        public Manager(string _name, int _age, int day, int month, int year, int _salary, string _type) : base(_name, _age, day, month, year, _salary)
        {
            setTypeOfManager(_type);
        }

        public override void print()
        {
            Console.WriteLine(" Manager:");
            base.print();
            Console.WriteLine($"  Type of manager: {getTypeOfManager()}\n");
        }
    }
}
