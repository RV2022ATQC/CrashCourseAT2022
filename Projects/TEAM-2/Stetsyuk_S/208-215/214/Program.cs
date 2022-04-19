//6.Користувач вводить з клавіатури число, необхідно показати на екран суму його цифр.
// Примітка: Наприклад, користувач ввів число 12345. 
// На екрані має з'явитися повідомлення про те, що сума цифр числа 15.
using System.Linq;

List<char> res = Console.ReadLine().ToList<char>();
int count = 0;
foreach (char c in res)
{
    if (Char.IsDigit(c))
        count += int.Parse(c.ToString());
}

Console.WriteLine(count);