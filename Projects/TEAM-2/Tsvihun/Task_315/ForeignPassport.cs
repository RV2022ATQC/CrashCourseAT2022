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


        public ForeignPassport(int id, string foreignid, string type, string name, string lastname, string address, DateOnly birth) :base(id, type, name, lastname, address, birth )
        {
            ForeignId = foreignid;
        

        }

        public new void ShowInfo()
        {
            Console.WriteLine($"Passport ID: {ForeignId} ({Type})\nName: {FirstName} {LastName}\nBirth: {Birth}\nAddress: {Address}");
        }
    }
}
