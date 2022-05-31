
/* Розробити клас Person, який містить відповідні члени для зберігання:
імені, віку, статі і телефонного номера.
Напишіть функції-члени, які зможуть змінювати ці члени даних індивідуально.
Напишіть функцію-член Person :: Print (), яка виводить відформатовані дані про людину.*/

using System;

namespace _303
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Oleg", 21, "Male", "+380987651019");
            Person p2 = new Person("Vlad101", 71, "Male", "+380989783016");
            Person p3 = new Person("Iryna", 10, "NotMale", "+38098638291");
            Person p4 = new Person("Olga", 156, "FeMale", "+380631998870");
            Person p5 = new Person("Kostia", -1, "Male", "+380988711230");
            p2.Print();
            p2.SetName("Vlad");
            p2.SetAge(25);
            p2.SetMobilePhone("+380989783011");
            Console.WriteLine("Data of p2 was changed! New data is:");
            p2.Print();
        }
    }
}
