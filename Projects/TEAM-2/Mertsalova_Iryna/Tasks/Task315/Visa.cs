using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task315
{
    public class Visa
    {
        #region fields

        private int id;
        private string countryFrom;
        private string countryTo;
        private DateTime dateFrom;
        private DateTime dateTo;
        private static int count = 1; 

        #endregion

        #region properties

        public int getId() { return id; }
        public void setId()
        {
            this.id = count;
            Console.WriteLine(count);
            count++;
        }
        public string getCountryFrom() { return this.countryFrom; }
        public void setCountryFrom(string _countryFrom) { this.countryFrom = _countryFrom; }
        public string getCountryTo() { return this.countryTo; }
        public void setCountryTo(string _countryTo) { this.countryTo = _countryTo; }
        public string getDateFrom() { return $"{this.dateFrom.Day}/{this.dateFrom.Month}/{this.dateFrom.Year}"; }
        public void setDateFrom(int day, int month, int year) { this.dateFrom = new DateTime(year, month, day); }
        public string getDateTo() { return $"{this.dateTo.Day}/{this.dateTo.Month}/{this.dateTo.Year}"; }
        public void setDateTo(int day, int month, int year) { this.dateTo = new DateTime(year, month, day); } 
       
        #endregion

        public Visa(string _countryFrom, 
            string _countryTo, 
            int dayFrom, int monthFrom, int yearFrom,
            int dayTo, int monthTo, int yearTo)
        {
            setCountryFrom(_countryFrom);
            setCountryTo(_countryTo);
            setDateFrom(dayFrom, monthFrom, yearFrom);
            setDateTo(dayTo, monthTo, yearTo);
            setId();
        }

        public override string ToString()
        {
            return $"   Visa {getId()}:" +
                $"\n    country from - {getCountryFrom()}," +
                $"\n    country to - {getCountryTo()}," +
                $"\n    date from - {getDateFrom()}," +
                $"\n    date to - {getDateTo()}\n";
        }
    }
}
