// See https://aka.ms/new-console-template for more information

//2.Дано натуральне число а (a <100). 
//Напишіть програму, що виводить на екран кількість цифр в цьому числі і суму цих цифр

ushort digit;
Console.Write("Enter digit: ");
digit = ushort.Parse(Console.ReadLine());
if (digit > 9)
{
    Console.Write("Two digits\n");
    Console.Write("Sum: " + (digit / 10) + " + " + (digit % 10) + " = " + (digit / 10 + digit % 10) + "\n");
}
else
{
    Console.Write("One digit\n");
    Console.Write("Sum = " + digit + "\n");
}
