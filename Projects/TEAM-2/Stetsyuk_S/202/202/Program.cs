// 2. Напишіть програму, яка переводить гривні в $, Є.

var sum = double.Parse(Console.ReadLine());
Console.WriteLine("Рryvnias: " + Math.Round(sum, 2));

var euro = sum / 32.08;
Console.WriteLine("Euros: " + Math.Round(euro, 2));

var dollar = sum / 29.3;
Console.WriteLine("Dollars: " + Math.Round(dollar, 2));