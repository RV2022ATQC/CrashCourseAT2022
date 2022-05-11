// 314
//Створіть клас Student, який буде містити інформацію про студента. За допомогою механізму наслідування,
// реалізуйте клас Aspirant (аспірант - студент, який готується до захисту кандидатської роботи) похідний від Student.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_314
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student vovchik = new Student("Volodya Abramovych", 4);
            vovchik.StudentInfo();

            Student misha = new Student ("Misha Konchuk", 5);
            misha.StudentInfo();

            Aspirant galatyuk = new Aspirant("Mykhailo Galatyuk", 6, "Polymers processes");
            galatyuk.StudentInfo();

        }
    }
}
