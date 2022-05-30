using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _316
{
    class President : Employer
    {
        public string CompanyName { get; set; }
        public President(string name, int age, int sallary, string companyName) : base(name, age, sallary)
        {
            CompanyName = companyName;
        }

        public override void Print()
        {
            base.Print();
            Console.Write("owner of company "+ CompanyName);
            Console.WriteLine();

        }
    }
}
