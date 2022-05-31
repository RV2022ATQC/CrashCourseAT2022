/* Створіть клас Passport (паспорт), який буде містити паспортну інформацію про громадянина України. За допомогою механізму наслідування, 
 * реалізуйте клас ForeignPassport (закордонний паспорт) похідний від Passport. 
 * Нагадаємо, що закордонний паспорт містить крім паспортних даних, також дані про візи, номер закордонного паспорта */



using System;

namespace _315
{
    class Program
    {
        static void Main(string[] args)
        {
            Passport vlad = new Passport("Klopotenko", "Vladyslav", "Ivanovich", "Male", "27.11.2005", "15.01.2025", "UKR", 21988671);
            ForeignPassport vladF = new ForeignPassport("Klopotenko", "Vladyslav", "Ivanovich", "Male", "27.11.2005", "15.01.2025", "UKR", 21988671, "FL3312", "Canada", "30.01.2030");
            vlad.ShowData();
            vladF.ShowData();
        }
    }
}
