//4.Написати програму, яка знаходить в масиві найменше непарне число і показує його на екран.
using System.Linq;

List<int> l = new List<int>();
Random random = new Random();

for (int i = 0; i < 10; i++)
{
    l.Add(random.Next(0, 10));
}

int min = 0, counter = 0; ;
Console.Write("Array: ");
foreach (int i in l)
{
    Console.Write(i + " ");
}

foreach (int i in l)
{
    counter++;
    if (i % 2 != 0)
    {
        min = i;
        break;
    }
}

for (int i = counter; i < l.Count; i++)
{
    if ((l[i] < min) && (l[i] % 2 != 0))
        min = l[i];
}

Console.WriteLine("\nMin and odd: " + min);
