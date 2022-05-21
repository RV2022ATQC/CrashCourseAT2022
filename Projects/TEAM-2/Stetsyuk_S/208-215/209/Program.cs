//1.Розробити програму, яка виводить на екран горизонтальну лінію з символів. 
//  Кількість символів, який використовувати символ, і яка буде лінія - вертикальна, 
//  або горизонтальна - вказує користувач.

Console.Write("Enter symbol: ");
var symbol = char.Parse(Console.ReadLine());
Console.Write("Enter quantity: ");
var quantity = int.Parse(Console.ReadLine());
int choice = 0;

while (true)
{
    Console.Write("\nChoose 1 for vertical line\nChoose 2 for horizontal line\nСhoice: ");
    choice = int.Parse(Console.ReadLine());
    if (choice != 1 && choice != 2)
        Console.WriteLine("Enter write choice");
    else
        break;
}

if (choice == 1)
    for (int i = 0; i < quantity; i++)
        Console.WriteLine(symbol);
else
    for (int i = 0; i < quantity; i++)
        Console.Write(symbol);