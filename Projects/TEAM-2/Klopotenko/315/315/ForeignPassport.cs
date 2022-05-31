using System;
using System.Collections.Generic;

namespace _315
{
    public class ForeignPassport : Passport
    {
        public string ForeignDocumentNumber;
        public Dictionary<string, string> Visa;

        public ForeignPassport(string Surname, string Name, string Patronymic, string Sex, string DateOfBirth, string DateOfExpiry, string Nationality, long DocumentNumber, string ForeignDocumentNumber, string VisaCountryName, string VisaDateOfExpiry) : base (Surname, Name, Patronymic, Sex, DateOfBirth, DateOfExpiry, Nationality, DocumentNumber)
        {
            this.ForeignDocumentNumber = ForeignDocumentNumber;
            Visa = new Dictionary<string, string>();
            Visa.Add(VisaCountryName, VisaDateOfExpiry);
        }

        public void ShowData()
        {
            Console.Write($"{base.Surname} {base.Name} {base.Patronymic}, Sex: {base.Sex}, Data of birth: {base.DateOfBirth}, Date of Expiry: {base.DateOfExpiry}, Nationality: {base.Nationality}, Docoment number: {base.DocumentNumber}, Foreign document number: {ForeignDocumentNumber} ");
            foreach (var visa in Visa)
            {
                Console.WriteLine($"Visa for: {visa.Key}, Date of visa expiry: {visa.Value}");
            }
        }
    }
}
