using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_315
{
    internal class Passport
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        
        // Need .NET 6
        public DateOnly Birth { get; set; }


        public Passport(int id, string type, string name, string lastname, string address, DateOnly birth)
        {
            Id = id;
            Type = type;
            FirstName = name;
            LastName = lastname;
            Address = address;
            Birth = birth;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Passport ID: {Id} ({Type})\nName: {FirstName} {LastName}\nBirth: {Birth}\nAddress: {Address}");
        }
    }
}
