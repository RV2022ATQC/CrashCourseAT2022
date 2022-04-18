// See https://aka.ms/new-console-template for more information

//1. Напишіть програму, яка перевіряє число, введене з клавіатури на парність.

Console.Write("Enter number: ");

var ch = double.Parse(Console.ReadLine());

if (ch % 2 == 0)
    Console.WriteLine("True");
else
    Console.WriteLine("False");