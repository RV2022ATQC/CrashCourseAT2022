using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _314
{
    class Aspirant : Student
    {
        public string Subject { get; set; }
        public string Thema { get; set; }
        public Aspirant(string name, string group, int age, string subject, string thema) : base(name, group, age)
        {
            Subject = subject;
            Thema = thema;
        }

        public override string ToString()
        {
            return "I'm " + Name + ", I'm" + Age + " student of " + Group + " group, I'm working at candidate work in subject "+Subject+ " on the topic"+Thema;
        }
    }
}
