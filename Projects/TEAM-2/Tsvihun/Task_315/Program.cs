// 315
// Створіть клас Passport (паспорт), який буде містити паспортну інформацію про громадянина України.
// За допомогою механізму наслідування, реалізуйте клас ForeignPassport (закордонний паспорт) похідний від Passport.
// Нагадаємо, що закордонний паспорт містить крім паспортних даних, також дані про візи, номер закордонного паспорта.
using System;

namespace Task_315
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Passport tsvihunav = new (
                35149528, "Internal", "Anton", "Tsvihun", "Kostromska str. 3, Rivne, Ukraine", new DateOnly(1986,11,17));

            tsvihunav.ShowInfo();
            
            Passport coleague1 = new (
                95132311, "Internal", "Yulia", "Mykhalska", "Bukovynska str. 8/14, Rivne, Ukraine", new DateOnly(1988,11,04));

            coleague1.ShowInfo();
            
            Passport coleague2Foreign = new ForeignPassport(1234, "E15142011", "International", "Yulia", "Mykhalska", "Bukovynska str. 8/14, Rivne, Ukraine", new DateOnly(1988,11,04));

            coleague2Foreign.ShowInfo();

        }
    }
}
