//3.Написати програму, яка знаходить в масиві значення, 
//  що повторюються два і більше разів, і показує їх на екран.

using System.Linq;

List<int> l = new List<int>();
Random r = new Random();

for (int i = 0; i < 10; i++)
{
    l.Add(r.Next(0, 10));
}

Console.Write("Array: ");
foreach (int el in l)
{
    Console.Write(el + " ");
}

Console.WriteLine();

List<int> l1 = new List<int>();

for (int i = 0; i < l.Count(); i++)
{
    for (int j = i + 1; j < l.Count(); j++)
    {
        if (l[i] == l[j])
        {
            l1.Add(l[i]);
        }
    }
}

var l2 = l1.Distinct();
Console.Write("Digit which are dublicated: ");
foreach (int el in l2)
{
    Console.Write(el + " ");
}