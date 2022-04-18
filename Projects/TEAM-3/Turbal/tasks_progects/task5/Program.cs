//5. Введіть три числа і виведіть на екран значення суми і добуток цих чисел.

float n1 = 0, n2 = 0, n3 = 0, sum = 0, mult = 0;
bool is_correct = true;

Console.WriteLine("Please, input first number:");
try
{
    n1 = Convert.ToSingle(Console.ReadLine());
}
catch
{
    Console.WriteLine("First input is not a number!");
    is_correct = false;
}

Console.WriteLine("Please, input second number:");
try
{
    n2 = Convert.ToSingle(Console.ReadLine());
}
catch
{
    Console.WriteLine("Second input is not a number!");
    is_correct = false;
}

Console.WriteLine("Please, input third number:");
try
{
    n3 = Convert.ToSingle(Console.ReadLine());
}
catch
{
    Console.WriteLine("Second input is not a number!");
    is_correct = false;
}

if (is_correct == true)
{ 
    sum = n1 + n2 + n3;
    mult = n1 * n2 * n3;
    Console.WriteLine($"The sum of the numbers is equal to {sum}, the product of the numbers is equal to {mult}");
}


