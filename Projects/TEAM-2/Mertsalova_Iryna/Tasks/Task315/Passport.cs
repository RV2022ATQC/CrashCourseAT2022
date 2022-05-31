using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task315
{
    public class Passport
    {
        #region fields
        private string documentNumber;
        private string surname;
        private string name;
        private string patronymic;
        private string sex;
        private DateTime dateOfBirth;
        private string nationality;
        #endregion

        #region properties

        public string getDocNumber() { return this.documentNumber; }
        public void setDocNumber(string _docNumber) { this.documentNumber = _docNumber; }
        public string getSurname() { return this.surname; }
        public void setSurname(string _surname) { this.surname = _surname; }
        public string getName() { return this.name; }
        public void setName(string _name) { this.name = _name; }
        public string getPatronymic() { return this.patronymic; }
        public void setPatronymic(string _patronymic) { this.patronymic = _patronymic; }
        public string getSex() { return this.sex; }
        public void setSex(string _sex) { this.sex = _sex; }
        public string getDateOfBirth() { return $"{this.dateOfBirth.Day}/{this.dateOfBirth.Month}/{this.dateOfBirth.Year}"; }
        public void setDateOfBirth(int day, int month, int year) { this.dateOfBirth = new DateTime(year, month, day); }
        public string getNationality() { return this.nationality; }
        public void setNationality(string _nationality) { this.nationality = _nationality; }

        #endregion

        public Passport(string _documentNumber,
            string _surname,
            string _name,
            string _patronymic,
            string _sex,
            int _day, int _month, int _year,
            string _nationality)
        {
            setDocNumber(_documentNumber);
            setSurname(_surname);
            setName(_name);
            setPatronymic(_patronymic);
            setSex(_sex);
            setDateOfBirth(_day, _month, _year);
            setNationality(_nationality);
        }

        public override string ToString()
        {
            return $"  Document number: {getDocNumber()}" +
                $"\n  Surname: {getSurname()}" +
                $"\n  Name: {getName()}" +
                $"\n  Patronymic: {getPatronymic()}" +
                $"\n  Sex: {getSex()}" +
                $"\n  Date of birth: {getDateOfBirth()}" +
                $"\n  Nationality: {getNationality()}\n";
        }
    }
}
