// 303
// Розробити клас Person, який містить відповідні члени для зберігання:
// імені, віку, статі і телефонного номера.
// Напишіть функції-члени, які зможуть змінювати ці члени даних індивідуально.
// Напишіть функцію-член Person :: Print (), яка виводить відформатовані дані про людину.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_303
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Print();
            Person person2 = new Person("Anton Vasylyovych", 35, "MAN", "0971234567");
            person2.Print();

            person2.Name = "What is your name?";
            person2.Print();
        }
    }
}
