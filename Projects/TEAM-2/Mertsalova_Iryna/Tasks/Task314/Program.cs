using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task314
{
    class Program
    {
        //Створіть клас Student, який буде містити інформацію про студента.
        //За допомогою механізму наслідування, реалізуйте клас Aspirant
        //(аспірант - студент, який готується до захисту кандидатської роботи) похідний від Student.
        static void Main(string[] args)
        {
            Student st1 = new Student("Maria", 18, 10.7);
            Student st2 = new Student("Lilia", 20, 9.6);
            Aspirant st3 = new Aspirant("Nina", 19, 11);

            Console.WriteLine("\n" + st1.ToString());
            Console.WriteLine(st2.ToString());
            Console.WriteLine(st3.ToString());
        }
    }
}
