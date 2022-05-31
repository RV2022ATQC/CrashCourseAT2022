using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task315
{
    public class ForeignPassport : Passport
    {
        private List<Visa> visas;
        public List<Visa> getVisas() { return visas; }
        public void setVisas(List<Visa> _visas) { this.visas = _visas; }
        public ForeignPassport(string _documentNumber,
            string _surname,
            string _name,
            string _patronymic,
            string _sex,
            int _day, int _month, int _year,
            string _nationality, List<Visa> visas) : base(_documentNumber,
                _surname,
                _name,
                _patronymic,
                _sex,
                _day, _month, _year,
                _nationality)
        {
            setVisas(visas);
        }

        public override string ToString()
        {
            string str = base.ToString() + "\n";
            foreach (var item in getVisas())
            {
                str += item.ToString();
            }

            return str;
        }
    }
}
