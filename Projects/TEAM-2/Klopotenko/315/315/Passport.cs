using System;
namespace _315
{
    public class Passport
    {
        public string Surname;
        public string Name;
        public string Patronymic;
        public string Sex;
        public string DateOfBirth;
        public string DateOfExpiry;
        public string Nationality;
        public long DocumentNumber;

        public Passport(string Surname, string Name, string Patronymic, string Sex, string DateOfBirth, string DateOfExpiry, string Nationality, long DocumentNumber)
        {
            this.Surname = Surname;
            this.Name = Name;
            this.Patronymic = Patronymic;
            this.Sex = Sex;
            this.DateOfBirth = DateOfBirth;
            this.DateOfExpiry = DateOfExpiry;
            this.Nationality = Nationality;
            this.DocumentNumber = DocumentNumber;
        }

        public void ShowData()
        {
            Console.WriteLine($"{Surname} {Name} {Patronymic}, Sex: {Sex}, Data of birth: {DateOfBirth}, Date of Expiry: {DateOfExpiry}, Nationality: {Nationality}, Docoment number: {DocumentNumber}");
        }
    }
}
