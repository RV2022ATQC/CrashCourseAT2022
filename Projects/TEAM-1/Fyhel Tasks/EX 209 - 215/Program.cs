using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_209___215
{
    class Program
    {
        static int EnterNumber()
        {
            string inputStr = Console.ReadLine();
            bool isNumber = true;

            for (int i = 0; i < inputStr.Length; i++)
                if (inputStr[i] < 48 || inputStr[i] > 57)
                    isNumber = false;
            while (inputStr.Equals("")|| isNumber == false)//checking for right input
            {
                isNumber = true;
                Console.WriteLine("\nERROR " + inputStr + " is not a number, try again:");
                inputStr = Console.ReadLine();
                for (int i = 0; i < inputStr.Length; i++)
                    if (inputStr[i] < 48 || inputStr[i] > 57)
                        isNumber = false;
            }

            return int.Parse(inputStr);
        }

        static string EnterString()
        {
            
            string inputStr = Console.ReadLine();
            while(inputStr.Equals(""))//checking for right input
            {
                
                Console.WriteLine("\nWrong line, try again:");
                inputStr = Console.ReadLine();
            }
            return inputStr;
        }
        static void EX_209()//1. Розробити програму, яка виводить на екран горизонтальну лінію з символів. Кількість символів, який використовувати символ, і яка буде лінія - вертикальна, або горизонтальна - вказує користувач.
        {
            char symbol = ' ';
            string inputStr=" ";
            int lengthOfLine, varriantOfLine;

            Console.WriteLine("\nEnter symbol for making line:");

            inputStr = EnterString();
            symbol = inputStr[0];


            Console.WriteLine("\nEnter length of line:");
            lengthOfLine = EnterNumber();
            while (lengthOfLine == 0)//checking for right input
            {
                Console.WriteLine("\nWrong line length, try again:");
                lengthOfLine = EnterNumber();
            }
            
            Console.WriteLine("\nEnter \n\n1 for gorizontal line or \n\n2 for vertical line or \n\n3 for diagonal line:");
            varriantOfLine = EnterNumber();
            while (varriantOfLine!=1 && varriantOfLine != 2 && varriantOfLine != 3)//checking for right input
            {
                Console.WriteLine("\nWrong line varriant, try again:");
                varriantOfLine = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n");


            switch (varriantOfLine)
            {
            case 1:
                    for (int i = 0; i < lengthOfLine; i++)//gorizontal
                        Console.Write(symbol);
                break;

            case 2:
                    for (int i = 0; i < lengthOfLine; i++)//vertical
                        Console.WriteLine(symbol);
                break;

             case 3:
                    for (int i = 0; i < lengthOfLine; i++)//diagonal 
                    {
                        for (int j = 0; j < i; j++)
                            Console.Write(" ");
                        Console.WriteLine(symbol);
                    }
                break;

            default:
                    Console.WriteLine("ERROR");
                break;
            }


            Console.ReadLine();
        }

        static void EX_212()//4. Користувач вводить з клавіатури число - програма повинна показати скільки в даному числі цифр. Число вводиться повністю в одну змінну. Примітка: Наприклад, користувач ввів число 11123445555.На екрані має з'явитися повідомлення про те, що в числі 5 цифр."

        {
            string numberInputStr = String.Empty;
            List<int> numbersList = new List<int>();

            Console.WriteLine("\nEnter number:");
            numberInputStr = EnterString();

            for(int i = 0; i< numberInputStr.Length;i++)//adding symbols to list
            {
                if(numberInputStr[i]<48|| numberInputStr[i]>57)
                {
                    Console.WriteLine("Error, letter in number!!!");
                    break;
                }
                numbersList.Add((int)numberInputStr[i] - 48);
            }

            numbersList = numbersList.Distinct().ToList();//calculating

            Console.WriteLine("\n\nThere are :" + numbersList.Count() + " unique numbers in " + numberInputStr + " .");
            Console.ReadLine();

        }

        
        static void EX_213()//5. Користувач вводить з клавіатури число, необхідно перевернути його (число) і вивести на екран.Примітка: Наприклад, користувач ввів число 12345.На екрані має з'явитися число навпаки - 54321."
        {
            
            string numberInputStr = String.Empty, numberReverseStr = String.Empty;

            Console.WriteLine("\nEnter number:");
            numberInputStr =EnterNumber().ToString();

            for (int i = numberInputStr.Length - 1; i >= 0; i--)//reversing
                numberReverseStr += numberInputStr[i];

            Console.WriteLine("Forvard - " + numberInputStr+"\n\nReverse - "+ numberReverseStr);

            Console.ReadLine();
        }

        static void EX_214()//6. Користувач вводить з клавіатури число, необхідно показати на екран суму його цифр.Примітка: Наприклад, користувач ввів число 12345.На екрані має з'явитися повідомлення про те, що сума цифр числа 15."
        {
            int numberInputInt;
            string numberInputStr = String.Empty, numberReverseStr = String.Empty;
            int sumOfsymbols=0;

            Console.WriteLine("\nEnter number:");
            numberInputInt = EnterNumber();
            numberInputStr = numberInputInt.ToString();


            for (int i = 0; i < numberInputStr.Length; i++)//calculating
                sumOfsymbols += (int)numberInputStr[i] - 48;

            Console.WriteLine("\nThe sum of symbols in " + numberInputStr + " is " + sumOfsymbols);

            Console.ReadLine();
        }

        static void EX_215()//7. Написати програму, яка виводить на екран - наступну фігуру:ширина і висота фігури встановлюються користувачем з клавіатури.
        /*

        *********************
        *                   *
        *                   *
        *                   *
        *                   *
        *********************

        */
        {
            int inputInt = 0 ;
            int lengthOfLine = 0, heightOfLine=0;

            Console.WriteLine("\nEnter height of line:");
            inputInt = EnterNumber();
            while (inputInt.Equals(null) || inputInt.Equals("0"))//checking for right input height
            {
                Console.WriteLine("\nWrong height, try again:");
                inputInt = EnterNumber();
            }
            heightOfLine = inputInt;

            Console.WriteLine("\nEnter length of line:");
            inputInt = EnterNumber();
            while (inputInt.Equals(null) || inputInt.Equals("0"))//checking for right input length
            {
                Console.WriteLine("\nWrong length, try again:");
                inputInt = EnterNumber();
            }
            lengthOfLine = inputInt;

            Console.Write("\n\n");
            for (int l = 0; l < lengthOfLine; l++)
                Console.Write("*");
            Console.Write("\n");
            for (int h = 0; h < heightOfLine - 2; h++)
            {
                Console.Write("*");
                if (lengthOfLine != 1)
                {
                    for (int l = 0; l < lengthOfLine - 2; l++)
                        Console.Write(" ");
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            if (heightOfLine!=1)
                for (int l = 0; l < lengthOfLine; l++)
                    Console.Write("*");

            Console.ReadLine();
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Enter:\n\n9  -  Ex 209\n12  -  Ex 212\n13  -  Ex 213\n14  -  Ex 214\n15  -  Ex 215\n");
            int varriant = -1;
            varriant = EnterNumber();

            switch (varriant)
            {
                case 9:
                    EX_209();
                    break;
                case 12:
                    EX_212();
                    break;
                case 13:
                    EX_213();
                    break;
                case 14:
                    EX_214();
                    break;
                case 15:
                    EX_215();
                    break;
            }
        }
    }
}
