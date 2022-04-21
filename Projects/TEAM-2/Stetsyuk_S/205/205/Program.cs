// See https://aka.ms/new-console-template for more information

//5.Введіть три числа і виведіть на екран значення суми і добуток цих чисел.

Console.Write("Enter first number: ");
var ch1 = double.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
var ch2 = double.Parse(Console.ReadLine());
Console.Write("Enter third number: ");
var ch3 = double.Parse(Console.ReadLine());

Console.WriteLine("Sum: " + (ch1 + ch2 + ch3));
Console.WriteLine("Product: " + (ch1 * ch2 * ch3));