
using System;

namespace task_301_317
{/*Написати клас Студент. Також реалізувати клас, що описує групу студентів.
    Передбачити можливість визначення середньої успішності групи за певним предметом.*/
    class Student
    {
        string Name;
        int Age;
        char Sex;
        int course;
        string faculty;
        string groupeName;
        public int[] subjects;

        public Student(string _Name, int _Age, char _Sex, int _course, string _faculty, string _groupeName, int[] _subjects)
        {
            Name = _Name;
            Age = _Age;
            Sex = _Sex;
            course = _course;
            faculty = _faculty;
            groupeName = _groupeName;
            subjects = _subjects;
        }
        public Student()
        { }
    }
    class StudentsGroup
    {
        public Student[] member;
        int array_size;
        /* public StudentsGroup(int _size)
         {
             member = new Student[_size];
             Student tmp = new Student();
             for (int i = 0; i < _size; i++) member[i] = tmp;
         }*/
        public StudentsGroup(Student name)
        {
            member = new Student[1];
            member[0] = name;
            Console.WriteLine(member.Length);
        }
        public StudentsGroup()
        { }
        public void Add(Student name)
        {

            Array.Resize(ref member, member.Length + 1);
            member[member.Length - 1] = name;
            Console.WriteLine(member.Length);

        }
        public float Average(int subject_number)
        {
            Student tmp = member[0];
            if (tmp.subjects.Length-1 <subject_number || subject_number < 0) return 0;
            float s = 0;
            foreach (var t in member) s += t.subjects[subject_number];
            // (CS1.Length > 0) 
            return s / member.Length;
            // else throw (string "Error size");
        }

    }




    internal class Program
    {
        private static void Main(string[] args)
        {
            //task 301
            /*Написати клас Товар. Також реалізувати клас магазин.
             Передбачити можливість отримання товару на баланс і продажу товару.*/
            /* Shop shop = new Shop();
       shop.Add(1, "Renault Cadjar", 11000f, 5);
       Console.WriteLine("size= " + (object) shop.size + " " + shop.Goods[shop.size - 1].Name + " " + (object) shop.Goods[shop.size - 1].cost + " " + (object) shop.Goods[shop.size - 1].count);
       shop.Sell(1, 2);
       Console.WriteLine("size= " + (object) shop.size + " " + shop.Goods[shop.size - 1].Name + " " + (object) shop.Goods[shop.size - 1].cost + " " + (object) shop.Goods[shop.size - 1].count);
       Console.ReadLine();*/
           
            //task 302
            /*Написати клас Студент. Також реалізувати клас, що описує групу студентів.
    Передбачити можливість визначення середньої успішності групи за певним предметом.*/
            int[] estimate = new int[] {5, 5, 5, 5, 5 };
            Student tmp = new Student("Turbal Yurii", 52, 'm', 1, "SoftServe", "CS", estimate);
            StudentsGroup CS1 = new StudentsGroup(tmp);
            int[] estimate1 = new int[] {3, 5, 4, 4, 7 };
            Student tmp1 = new Student("Turbal Mar", 22, 'f', 1, "SoftServe", "CS", estimate1);
            CS1.Add(tmp1);
            try
            {
                Console.WriteLine("Average=" + CS1.Average(4));
            }

            catch (DivideByZeroException)
            {
                // Перехватить исключение.
                Console.WriteLine("Devide by zero");
            }
            Console.ReadLine();
        }
    }
}

