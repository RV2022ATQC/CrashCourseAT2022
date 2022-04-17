using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_220_226
{
    class tasks
    {
        public DateTime currentDay;
        public tasks()
        {
            currentDay = DateTime.Today;
        }
        /*Написати overload методи Add які в залежності від параметрів або додають цифрові значення,
         або об'єднують введені тексти. Передбачити аргументи за замовчуванням і використання глобальних змінних.*/
        public int Add(int a, int b = 0)
        {
            return a + b;
        }
        public string Add(string s1, string s2 = "!")
        {
            return s1 + s2;
        }
        /*Написати overload методи RemoveFromString, які приймають текст і видаляють з нього або
         певний набір символів, або символ\символи за порядковим номером в тексті. 
         Реалізувати використання аргументів за замовчуванням та глобальних\локальних змінних*/
        public string RemoveFromString(string s, int num)
        {
           return s.Remove(num, 1);
        }
        public string RemoveFromString(string s, int num, int count)
        {
            return s.Remove(num, count);
        }
        public string RemoveFromString(string s, string removeSet)
        {
            int i ;
            foreach (char ch in removeSet)
            {
                // Console.Write(ch);
                  i = 0;
                while (i < s.Length)
                { if (ch == s[i]) s.Remove(i, 1); else i++; }
        }      
                
            return s;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            tasks t1 = new tasks();
            Console.WriteLine(t1.Add("Hello"));
            Console.WriteLine(t1.RemoveFromString("Hello",2,3));
            Console.WriteLine(t1.RemoveFromString("Hello", "Hl"));
            Console.ReadLine();
        }
    }
}
