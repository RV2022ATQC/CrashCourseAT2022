//1.Написати програму, яка виводить вміст масиву навпаки
//Приклад: масив 23 11 6 42 перетворюється в 42 6 11 23.

int[] l = new int[4];
Random random= new Random();
for(int i=0; i<l.Length; i++)
{
    l[i] = random.Next(0, 10);
}


Console.Write("Initial array: ");
foreach (int el in l)
{
    Console.Write(el + " ");
}

Array.Reverse(l);

Console.Write("\nReverse array: ");
foreach (int el in l)
{
    Console.Write(el + " ");
}