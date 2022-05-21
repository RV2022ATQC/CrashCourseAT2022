using System;

namespace _315
{
    class Passport
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime Date { get; set; }
        public DateTime Isuued { get; set; }
        public DateTime ValidUntil { get; set; }

        public Passport(int id, string fullName, string date, string isuued, string validUntil)
        {
            Id = id;
            FullName = fullName;
            Date = DateTime.Parse(date);
            Isuued = DateTime.Parse(isuued);
            ValidUntil = DateTime.Parse(validUntil);
        }

        public override string ToString()
        {
            return "Ukrainian passpot\nId: " + Id + ", Full name: " + FullName + ", birtday date " + Date.ToString("dd.MM.yyyy") + "; passpord was issued " + Isuued.ToString("dd.MM.yyyy") + " valid until " + ValidUntil.ToString("dd.MM.yyyy");
        }
    }
}
