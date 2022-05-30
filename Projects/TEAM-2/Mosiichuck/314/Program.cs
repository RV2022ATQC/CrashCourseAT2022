using System;

namespace _314
{
    internal class Program
    {
        //Створіть клас Student, який буде містити інформацію про студента. За допомогою механізму наслідування,
        //реалізуйте клас Aspirant (аспірант - студент, який готується до захисту кандидатської роботи) похідний від Student.
        static void Main(string[] args)
        {
            Student student = new Student("Olga Fraid", "EEE-11", 21);
            Console.WriteLine(student.ToString());

            Console.WriteLine();
            Aspirant aspirant = new Aspirant("Stephan Rudenko", "EEE-31", 24, "ecologia", "life without brain");
            Console.WriteLine(aspirant.ToString());

        }
    }
}
