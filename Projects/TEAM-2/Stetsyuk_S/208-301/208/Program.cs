//3. Відомо, що 1 дюйм дорівнює 2.54 см.
//Розробити додаток, що переводять дюйми в сантиметри і навпаки.
//Діалог з користувачем реалізувати через систему меню

Console.Write("Enter length: ");
var length = double.Parse(Console.ReadLine());
var value = 'c';
while (true)
{
    Console.WriteLine("Enter 1 to convert to inches.");
    Console.WriteLine("Enter 2 to convert to centimeters.");
    Console.Write("Enter 3 to stop.\nChoise: ");
    var choise = int.Parse(Console.ReadLine());
    if (choise == 3)
        return;

    if (value == 'c')
    {
        switch (choise)
        {
            case 1:
                length /= 2.54;
                value = 'i';
                Console.WriteLine(Math.Round(length, 3) + " inches");
                break;
            case 2:
                length *= 1;
                Console.WriteLine(Math.Round(length, 3) + " centimeters");
                break;
            default:
                Console.WriteLine("Enter correct number");
                break;
        }
    }
    else
    {
        switch (choise)
        {
            case 2:
                length *= 2.54;
                value = 'c';
                Console.WriteLine(Math.Round(length, 3) + " centimeters");
                break;
            case 1:
                length *= 1;
                Console.WriteLine(Math.Round(length, 3) + " inches");
                break;
            default:
                Console.WriteLine("Enter correct number");
                break;
        }
    }
}