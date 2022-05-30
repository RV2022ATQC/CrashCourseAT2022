using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _315
{
    class ForeignPassport : Passport
    {
        List<string> visas;

        public ForeignPassport(int id, string fullName, string date, string isuued, string validUntil) : base(id, fullName, date, isuued, validUntil)
        {
            visas = new List<string>();
        }

        public void AddVisa(string visa)
        {
            bool isUsed = false;
            foreach (var item in visas)
            {
                if (item == visa)
                    isUsed = true;
            }
            if (!isUsed)
                visas.Add(visa);
        }

        public override string ToString()
        {
            string visas = "";
            foreach (var item in this.visas)
            {
                visas += item + ", ";
            }
            return "Foreign passpot\nId: " + Id + ", Full name: " + FullName + ", birtday date " + Date.ToString("dd.MM.yyyy") + "; passpord was issued " + Isuued.ToString("dd.MM.yyyy") + " valid until " + ValidUntil.ToString("dd.MM.yyyy") + ", visas: " + visas;

        }
    }
}
