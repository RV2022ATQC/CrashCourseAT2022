using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task314
{
    public class Aspirant : Student
    {
        public Aspirant(string _name, int _age, double _averMark) : base(_name, _age, _averMark)
        {
            Console.WriteLine($"  {getName()} is an aspirant!");
        }
    }
}
