using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_315
{
    class ForeignPassport : Passport
    {
        public string ForeignId { get; set; }
        public string Visas { get; set; }


        public ForeignPassport(int id, string foreignid, string type, string name, string lastname, string address, DateOnly birth, string visas) 
            :base(id, type, name, lastname, address, birth)
        {
            ForeignId = foreignid;
            Visas = visas;
        }

        public new void ShowInfo()
        {
            Console.WriteLine($"Passport ID: {ForeignId} ({Type})\nName: {FirstName} {LastName}\nBirth: {Birth}\nAddress: {Address}\nVisas: {Visas}");
        }
    }
}
