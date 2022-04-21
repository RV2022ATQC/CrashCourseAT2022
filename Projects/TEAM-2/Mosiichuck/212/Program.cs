using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _212
{
    class Program
    {
        //Користувач вводить з клавіатури число - програма повинна показати скільки в даному числі цифр. Число вводиться повністю в одну змінну.
        //Примітка: Наприклад, користувач ввів число 11123445555. На екрані має з'явитися повідомлення про те, що в числі 5 цифр
        static void Main(string[] args)
        {
            int num = 0, temp = 0, counter = 0;
            bool isUnique = true;
            string uniqNumbers = "";
            Console.Write("Enter number: ");
            num = Int32.Parse(Console.ReadLine());
            do
            {
                temp = num % 10;
                Console.WriteLine(num % 10);
                isUnique = true;
                if (counter == 0)
                {
                    uniqNumbers += temp;
                    isUnique = false;
                    counter++;
                }
                for (int i = 0; i < counter; i++)
                {
                    if (Int32.Parse(uniqNumbers[i].ToString()) == temp)
                    {
                        isUnique = false;
                    }
                }
                if (isUnique)
                {
                    counter++;
                    uniqNumbers += temp;
                }
                num /= 10;
            } while (num != 0);
            Console.WriteLine("\n" + uniqNumbers);
        }
    }
}
