// See https://aka.ms/new-console-template for more information

//1.Напишіть програму, яка обчислює середнє арифметичне двох чисел.

Console.Write("Enter first number: ");
var ch1 = double.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
var ch2 = double.Parse(Console.ReadLine());

var average = (ch1 + ch2) / 2;

Console.Write("Average: " + average);
