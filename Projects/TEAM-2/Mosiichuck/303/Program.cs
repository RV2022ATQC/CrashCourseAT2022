using System;

namespace _303
{
    class Program
    {
        //Розробити клас Person, який містить відповідні члени для зберігання: імені, віку, статі і телефонного номера.
        //Напишіть функції-члени, які зможуть змінювати ці члени даних індивідуально.Напишіть функцію-член Person :: Print (), яка виводить відформатовані дані про людину.
        static void Main(string[] args)
        {
            Person person = new Person("Olga Stranger", 12, "girl", "0973456711");
            person.Print();
        }
    }
}
