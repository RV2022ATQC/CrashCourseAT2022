using System;

namespace AVG
{
    class Program
{
    static void Main(string[] args)
    {
        string first = Console.ReadLine(); 
            string second = Console.ReadLine();

            float avg = (Int32.Parse(first) + Int32.Parse(second)) /2;

           Console.WriteLine(avg);
    }
}
}