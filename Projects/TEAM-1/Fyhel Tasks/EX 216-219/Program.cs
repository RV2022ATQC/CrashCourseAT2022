using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_216_219
{
    class Program
    {
        
        static void EX_216()//1. Написати програму, яка виводить вміст масиву навпаки. Приклад: масив 23 11 6 перетворюється в 6 23 11.
        {
            int lengthOfMassiv = 9;
            int[] massiv = new int[lengthOfMassiv];

            for (int i = 0; i < massiv.Length; i++)
                massiv[i] = i;

            Console.WriteLine("Initial massiv: ");
            foreach (int i in massiv)
                Console.Write(i + ", ");

            Console.WriteLine("Reversed massiv: ");
            for(int i = massiv.Length-1;i>=0 ; i--)
                Console.Write(massiv[i] + ", ");

            Console.ReadLine();
        }

        static void EX_218()//3. Написати програму, яка знаходить в масиві значення, що повторюються два і більше разів, і показує їх на екран.

        {
            int lengthOfMassiv = 20;
            int[] massivInt = new int[lengthOfMassiv];
            List<int> massivList = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < massivInt.Length; i++)//fill massive
                massivInt[i] = rnd.Next(0, 10) - 5;
            

            for(int i = 0; i < massivInt.Length-1;i++)//calculating
            {
                for (int j = i + 1; j < massivInt.Length; j++)
                    if (massivInt[i] == massivInt[j])
                    {
                        massivList.Add(massivInt[i]);
                        continue;
                    }
            }
            massivList = massivList.Distinct().ToList();

            Console.WriteLine("Initial massiv: ");
            foreach (int i in massivInt)
                Console.Write(i + ", ");

            Console.WriteLine("\nProcessed massiv: ");
            foreach (int i in massivList)
                Console.Write(i + ", ");

            if (massivList.Count == 0)
                Console.Write("is Empty");

            Console.ReadLine();
        }

        
        static void EX_219()//4. Написати програму, яка знаходить в масиві найменше непарне число і показує його на екран.
        {
            
            int lengthOfMassiv = 10;
            int[] massivInt = new int[lengthOfMassiv];
            int resultNumber=21;
            Random rnd = new Random();

            for (int i = 0; i < massivInt.Length; i++)//fill massive
                massivInt[i] = rnd.Next(0, 20) - 10;

            foreach(int i in massivInt)//searching the lowest not pair number
            {
                if (i % 2 != 0 && i < resultNumber)
                    resultNumber = i;
            }

            if (resultNumber != 21)
                Console.Write("\n\tThe lowest not pair number from: ");
            foreach (int i in massivInt)
                Console.Write(i + ", ");
            Console.Write(" is (" + resultNumber + ").");


            Console.ReadLine();
        }

            static void Main(string[] args)
        {
            Console.WriteLine("Enter:\n\n16  -  Ex 216\n18  -  Ex 218\n19  -  Ex 219\n\n");
            int varriant = -1;
            varriant = int.Parse(Console.ReadLine());

            switch (varriant)
            {
                case 16:
                    EX_216();
                    break;
                case 18:
                    EX_218();
                    break;
                case 19:
                    EX_219();
                    break;
            }
        }
    }
}
