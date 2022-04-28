﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task220
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Написати overload методи Add які в залежності від параметрів або додають цифрові значення, або об'єднують введені тексти.
            //Передбачити аргументи за замовчуванням і використання статичних полів\методів

            
            int t1; 
            int t2;
            
            Console.WriteLine("Enter first object");
            var i1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter second object");
            var i2 = Convert.ToString(Console.ReadLine());

            try
            {
                t1 = Convert.ToInt32(i1);
                t2 = Convert.ToInt32(i2);
                Add(t1, t2);
            }
            catch (Exception ex)
            {
                Add(i1, i2);
            }

        }
        static void Add(int x, int y)
        {
            Console.WriteLine($"{x + y}");
        }
        static void Add(string x, string y)
        {
            Console.WriteLine(String.Concat(x, y));

        }
    }
}