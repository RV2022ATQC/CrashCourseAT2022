using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task303
{
    class Program
    {
        //Розробити клас Person, який містить відповідні члени для зберігання:
        //імені, віку, статі і телефонного номера.
        //Напишіть функції-члени, які зможуть змінювати ці члени даних індивідуально.
        //Напишіть функцію-член Person :: Print (), яка виводить відформатовані дані про людину."
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person("Iryna", 18, "woman", "0678598358"));
            people.Add(new Person("Marina", 25, "woman", "096802358"));
            people.Add(new Person("Alex", 22, "man", "068014558"));
            Console.WriteLine();

            foreach (var item in people)
            {
                item.Print();
            }
            Console.WriteLine(" -----------------------------------------");
        }
    }
}
