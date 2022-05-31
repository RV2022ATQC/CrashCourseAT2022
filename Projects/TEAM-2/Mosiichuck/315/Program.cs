using System;

namespace _315
{
    class Program
    {
        //Створіть клас Passport (паспорт), який буде містити паспортну інформацію про громадянина України.
        //За допомогою механізму наслідування, реалізуйте клас ForeignPassport (закордонний паспорт)
        //похідний від Passport. Нагадаємо, що закордонний паспорт містить крім паспортних даних,
        //також дані про візи, номер закордонного паспорта.
        static void Main(string[] args)
        {
            Passport passport = new Passport(12332993,"Stephan Boduk","12.07.1999","28.11.2020", "28.11.2024");
            Console.WriteLine(passport.ToString());

            Console.WriteLine();
            ForeignPassport foreignPassport = new ForeignPassport(12112993, "Grim Stream", "22.12.1977", "08.01.2014", "08.01.2024");
            foreignPassport.AddVisa("Poland");
            foreignPassport.AddVisa("USA");
            Console.WriteLine(foreignPassport.ToString());
        }
    }
}
