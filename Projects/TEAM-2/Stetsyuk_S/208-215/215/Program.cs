//7.Написати програму, яка виводить на екран - наступну фігуру:
//*********************                                                                                                                                                                                                        
//*                   *
//*                   *
//*                   *
//*                   *
//*********************
//ширина і висота фігури встановлюються користувачем з клавіатури.

Console.Write("Enter height: ");
var height = int.Parse(Console.ReadLine());
Console.Write("Enter width: ");
var width = int.Parse(Console.ReadLine());

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        if ((j == 0) || (j == width - 1) || (i == 0) || (i == height - 1))
            Console.Write("*");
        else
            Console.Write(" ");
    }
    Console.WriteLine();
}