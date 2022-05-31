using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task315
{
    class Program
    {
        //Створіть клас Passport (паспорт), який буде містити паспортну
        //інформацію про громадянина України. За допомогою механізму наслідування,
        //реалізуйте клас ForeignPassport (закордонний паспорт) похідний від Passport.
        //Нагадаємо, що закордонний паспорт містить крім паспортних даних, також дані про візи, номер закордонного паспорта.
        static void Main(string[] args)
        {
            List<Visa> visas1 = new List<Visa>()
            {
                new Visa("Ukraine", "Poland", 12, 03, 2022, 12, 06, 2022),
                new Visa("Poland", "Germany", 13, 06, 2022, 13, 08, 2022),
                new Visa("Germany", "Ukraine", 14, 08, 2022, 14, 10, 2022)
            };
            Passport passport1 = new Passport("0154986200", "Kravchuk", "Olena", "Anatoliivna", "woman", 10, 05, 2004, "ukrainian");
            Passport passport2 = new Passport("1486500542", "Melnuk", "Semen", "Olexandrovich", "man", 22, 11, 2000, "ukrainian");
            Passport passport3 = new Passport("7002587350", "Daviduk", "Maria", "Sergiivna", "woman", 02, 01, 2002, "ukrainian");
            ForeignPassport foreignPassport = new ForeignPassport(passport1.getDocNumber(), 
                passport1.getSurname(), 
                passport1.getName(),
                passport1.getPatronymic(),
                passport1.getSex(),
                10, 05, 2004, 
                passport1.getNationality(),
                visas1);

            Console.WriteLine(passport1.ToString());
            Console.WriteLine(passport2.ToString());
            Console.WriteLine(passport3.ToString());
            Console.WriteLine(foreignPassport.ToString());
        }
    }
}
