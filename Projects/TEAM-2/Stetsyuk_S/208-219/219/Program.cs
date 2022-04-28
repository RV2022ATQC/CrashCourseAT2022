//4.Написати програму, яка знаходить в масиві найменше непарне число і показує його на екран.
using System.Linq;

List<int> l = new List<int> ();
Random random = new Random ();

for (int i = 0; i < 10; i++)
{
    l.Add (random.Next(0, 10));
}

Console.Write("Array: ");
foreach (int i in l)
{
    Console.Write(i + " ");
}

int min = l[0];
foreach (int i in l)
{
    if ((i < min) && (i % 2 != 0))
        min = i;
}

Console.WriteLine("\nMin and odd: " + min);
