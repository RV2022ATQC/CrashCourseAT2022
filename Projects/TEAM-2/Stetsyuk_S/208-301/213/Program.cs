//5.Користувач вводить з клавіатури число, необхідно перевернути його (число) 
//  і вивести на екран.Примітка: Наприклад, користувач ввів число 12345. 
//  екрані має з'явитися число навпаки - 54321.

var ch = Console.ReadLine();
string output = new string(ch.ToCharArray().Reverse().ToArray());
Console.WriteLine(output);