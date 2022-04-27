
using System;

namespace task_301_317
{/*Написати клас Студент. Також реалізувати клас, що описує групу студентів.
    Передбачити можливість визначення середньої успішності групи за певним предметом.*/

    class Student
    {
        int[] sta = { 0 };
        protected string Name;
        protected int Age;
        protected char Sex;
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

        public Student(string _Name, int _Age, char _Sex, int _course, int[] _subjects)
        {
            Name = _Name;
            Age = _Age;
            Sex = _Sex;
            course = _course;
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
            if (tmp.subjects.Length - 1 < subject_number || subject_number < 0) return 0;
            float s = 0;
            foreach (var t in member) s += t.subjects[subject_number];
            // (CS1.Length > 0) 
            return s / member.Length;
            // else throw (string "Error size");
        }

    }

    /*Розробити клас Person, який містить відповідні члени для зберігання:
    імені, віку, статі і телефонного номера.
    Напишіть функції-члени, які зможуть змінювати ці члени даних індивідуально. Напишіть функцію-член Person :: 
    Print (), яка виводить відформатовані дані про людину.*/
    internal class Person
    {
        protected string Name;
        protected int Age;
        protected string Sex;
        protected string Fonenumber;
        public Person()
        { }
        public Person(string _Name,int _Age, string _Sex, string _Fonenumber=" ")
        {
            Name = _Name;
            Age = _Age;
            Sex = _Sex;
            Fonenumber = _Fonenumber;
        }
        public string get_Name()
        { return Name; }
        public void set_Name(string _Name)
        { Name = _Name; }
        public int get_Age()
        { return Age; }
        public void set_Age(int _Age)
        { Age = _Age; }
        public string get_Sex()
        { return Sex; }
        public void set_Sex(string _Sex)
        { Sex = _Sex; }
        public string get_Fonenumber()
        { return Fonenumber; }
        public void set_Fonenumber(string _Fonenumber)
        { Fonenumber = _Fonenumber; }
        public void Print()
        {
            Console.WriteLine($"Name= {Name}; Age= {Age}; Sex= {Sex}; Fonenumber= {Fonenumber} ");

        }
    }
    /*304
     Розробити клас StringRow, який в подальшому буде використовуватися для роботи з рядками. Клас повинен містити:
конструктор за замовчуванням, що дозволяє створити рядок довжиною 80 символів;
конструктор, що дозволяє створювати рядок довільного розміру;
конструктор, який створює об'єкт і ініціалізує його рядком, отриманим від користувача.
Клас повинен містити методи для введення рядків з клавіатури і виведення рядків на екран
     */
    class StringRow
    {
        string s;
        public StringRow()
        {
            char[] si = new char[80];
            s = new string(si);
        }
        public StringRow(string _s)
        {
            s = _s;
        }
        public StringRow(int size)
        {
            char[] si = new char[size];
            s = new string(si);
        }
        public void set()
        {
            s = Console.ReadLine();
        }
        public void get()
        {
            Console.WriteLine(s);
        }

    }
    /*305 Створіть клас Student, який буде містити інформацію про студента. За допомогою механізму наслідування, реалізуйте клас Aspirant
     (аспірант - студент, який готується до захисту кандидатської роботи) похідний від Student.*/
    class Aspirant : Student
    {
        string scientific_work;
        public Aspirant(string _Name, int _Age, char _Sex, int _course, int[] _subjects, string _sw) : base(_Name, _Age, _Sex, _course, _subjects)
        {
            scientific_work = _sw;
        }
        public Aspirant()
        {

        }
        public string get_Scientific()
        { return scientific_work; }
        public void set_Scientific(string _s)
        { scientific_work = _s; }

    }
    /*Створіть клас Passport (паспорт), який буде містити паспортну інформацію про громадянина України. За допомогою механізму наслідування, реалізуйте клас ForeignPassport (закордонний паспорт) похідний від Passport.
     Нагадаємо, що закордонний паспорт містить крім паспортних даних, також дані про візи, номер закордонного паспорта.*/
    class Passport:Person
        {
       protected  string series;
        protected string Number;
        protected string DateOfReseive;
        protected string OrganizeOfIssue;
        protected string DateOfBirsday;
        protected string PlaseOfBirsday;
        public Passport(string _Name, int _Age, string _Sex,string _series, 
            string _Number, string _DateOfReseive, 
            string _OrganizeOfIssue, string _DateOfBirsday, string _PlaseOfBirsday):base(_Name, _Age, _Sex)
        {
            _series = _series;
            Number = _Number;
            DateOfReseive = _DateOfReseive;
            OrganizeOfIssue = _OrganizeOfIssue;
            DateOfBirsday = _DateOfBirsday;
            PlaseOfBirsday = _PlaseOfBirsday;

        }
        public Passport() { }

    }
    class ForeignPassport : Passport
    {
        string[] vizas;
        public ForeignPassport(string _Name, int _Age, string _Sex, string _series,
            string _Number, string _DateOfReseive,
            string _OrganizeOfIssue, string _DateOfBirsday, 
            string _PlaseOfBirsday,string[] _vizas) : 
            base(_Name,_Age,_Sex, _series,
            _Number,_DateOfReseive,
            _OrganizeOfIssue, _DateOfBirsday, _PlaseOfBirsday)
        {
            vizas = _vizas;
            
        }
        public ForeignPassport() { }
    }
    /*316
     Створити абстрактний базовий клас Employer (службовець) з віртуальною функцією Print (). Створіть три класи нащадки: 
     President, Manager, Worker. Перевизначите функцію Print () для виведення інформації, 
     відповідає кожному типу службовця.*/

    abstract class Employer
    {
       protected  string name;
        protected int age;
        protected string education;
        protected int workperiod;
        protected string bank_account;
        protected string contact;
        public Employer()
        {
        }
        public Employer(string _name,int _age,string _edu,
            int _workper, string contact = " ", string _bank_account = " " )
        { name = _name;
            age = _age;
            education = _edu;
            workperiod = _workper;
            bank_account = _bank_account;
        }
        public void set_bank_account(string _bank_account)
        {
            bank_account = _bank_account;
        }
        public string get_bank_account()
        {
            return bank_account;
        }
        public void set_contact(string _contact)
        {
            contact = _contact;
        }
        public string get_contact()
        {
            return contact;
        }
        public abstract  void Print();
    }
    class Manager :Employer
    {
        string[] personal_contacts;
        Manager(string _name, int _age, string _edu, int _workper, string _contact, string[] _cont):
            base(_name, _age,_edu, _workper,_contact)
        {
            personal_contacts = _cont;
        }
        public override void Print()
        {
           Console.WriteLine($"name={name} contact-{contact}");
        }
    }
    class Worker : Employer
    {
        string speciality;
        public Worker(string _name, int _age, string _edu, int _workper, string _contact, string _spec) :
            base(_name, _age, _edu, _workper, _contact)
        {
            speciality = _spec;
        }
        public override void Print()
        {
            Console.WriteLine($"name={name} contact-{contact} speciality-{speciality}");
        }
    }
    class President : Employer
    {
        string[] schedule;
         public President(string _name, int _age, string _edu, int _workper, string _contact, string[] meet) :
            base(_name, _age, _edu, _workper, _contact)
        {
            schedule = meet;
        }
        public override void Print()
        {
            for (int i = 0; i < schedule.Length; i++) Console.WriteLine(schedule[i]);
        }
    }

    /*317
     Створити абстрактний базовий клас з віртуальною функцією - площа.
     Створити похідні класи: прямокутник, коло, прямокутний трикутник, трапеція зі своїми функціями площі. Для перевірки 
     визначити масив посилань на абстрактний клас, яким присвоюються адреси різних об'єктів. Площа трапеції: S = (a + b) h / 2 */
    abstract class Shape
    {
        protected string name;
        protected float[] par;
        public float[] get_par()
        {
            return par;
        }
        public string get_name()
        {
            return name;
        }
        public Shape(string _name)
        {
            name = _name;
        }
        public Shape()
        { }
        public abstract float Area();
    }
    class Rectangle : Shape
    {
        public Rectangle(string _name,float a, float b):base(_name)
        {
            par = new float[2];
            par[0] = a;
            par[1] = b;
        }
        public override float Area()
        {
            return par[0] * par[1];
        }
        
    }
    class Sircle : Shape
    {
        public Sircle(string _name,float r):base(_name)
        {
            par = new float[1];
            par[0] = r;
        }
        public override float Area() 
        {
            return par[0] * par[0]*(float)Math.PI;
        }

    }

    class Right_triangle : Shape
    {
        public Right_triangle(string _name,float a, float b): base(_name)
        {
            par = new float[2];
            par[0] = a;
            par[1] = b;
        }
        public override float Area()
        {
            return par[0] * par[1] * 0.5f;
        }

    }
    class Trapezoid : Shape
    {
        public Trapezoid(string _name,float a, float b,float h): base(_name)
        {
            par = new float[3];
            par[0] = a;
            par[1] = b;
            par[2] = h;
        }
        public override float Area()
        {
            return (par[0] + par[1]) * par[2];
        }

    }
   
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введіть номер задачі для перевірки( 301-304, 314-317)");
            int k = int.Parse(Console.ReadLine());
            switch (k)
            {
                case 301:
                    /*Написати клас Товар. Також реалізувати клас магазин.
                                 Передбачити можливість отримання товару на баланс і продажу товару.*/
                     Shop shop = new Shop();
               shop.Add(1, "Renault Cadjar", 11000f, 5);
               Console.WriteLine("size= " + (object) shop.size + " " + shop.Goods[shop.size - 1].Name + " " + (object) shop.Goods[shop.size - 1].cost + " " + (object) shop.Goods[shop.size - 1].count);
               shop.Sell(1, 2);
               Console.WriteLine("size= " + (object) shop.size + " " + shop.Goods[shop.size - 1].Name + " " + (object) shop.Goods[shop.size - 1].cost + " " + (object) shop.Goods[shop.size - 1].count);
               Console.ReadLine();
                    break;
                case 302:
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
                    break;
                case 303:
                    /*Розробити клас Person, який містить відповідні члени для зберігання:
   імені, віку, статі і телефонного номера.
   Напишіть функції-члени, які зможуть змінювати ці члени даних індивідуально. Напишіть функцію-член Person :: 
   Print (), яка виводить відформатовані дані про людину.*/
                    Person A = new Person();
                    A.set_Name("Vova");
                    A.set_Age(124);
                    A.set_Sex("man");
                    A.set_Fonenumber("+380980841867");
                    A.Print();
                    Console.ReadLine();
                    break;
                case 304:
                    /*305 Створіть клас Student, який буде містити інформацію про студента. За допомогою механізму наслідування, реалізуйте клас Aspirant
     (аспірант - студент, який готується до захисту кандидатської роботи) похідний від Student.*/
                    int[] fg = new[] { 4,3,3};
                    Aspirant mar = new Aspirant("Mar", 12, 'd', 2,fg,"Probability processes");
                    break;
                case 314:
                    /*Створіть клас Passport (паспорт), який буде містити паспортну інформацію про громадянина України. За допомогою механізму наслідування, реалізуйте клас ForeignPassport (закордонний паспорт) похідний від Passport.
     Нагадаємо, що закордонний паспорт містить крім паспортних даних, також дані про візи, номер закордонного паспорта.*/
                    break;
                case 315:
                    /*Створити абстрактний базовий клас Employer(службовець) з віртуальною функцією Print(). Створіть три класи нащадки: 
     President, Manager, Worker.Перевизначите функцію Print() для виведення інформації, 
     відповідає кожному типу службовця.*/

                    break;
                case 316:
                    /*316
     Створити абстрактний базовий клас Employer (службовець) з віртуальною функцією Print (). Створіть три класи нащадки: 
     President, Manager, Worker. Перевизначите функцію Print () для виведення інформації, 
     відповідає кожному типу службовця.*/
                    string[] s = new string[] { "ddd", "fgh", "qqqqqqqq" };
                    President zel = new President("Zelens",12,"qerqee",5,"safaf",s);
                    zel.Print();
                    break;
                case 317:
                    /*    Створити абстрактний базовий клас з віртуальною функцією - площа.
         Створити похідні класи: прямокутник, коло, прямокутний трикутник, трапеція зі своїми функціями площі. Для перевірки
         визначити масив посилань на абстрактний клас, яким присвоюються адреси різних об'єктів. Площа трапеції: S = (a + b) h / 2 */
                    Shape[] mas = new Shape[4];
                    Rectangle a = new Rectangle("Rectangle", 1, 2);
                    Sircle b = new Sircle("Sircle", 2);
                    Right_triangle c = new Right_triangle("Right_triangle", 1, 2);
                    Trapezoid d = new Trapezoid("Trapezoid", 1, 2, 3);
                    mas[0] = a;
                    mas[1] = b;
                    mas[2] = c;
                    mas[3] = d;

                    for (int i = 0; i < 4; i++) Console.WriteLine(mas[i].get_name());
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Введіть вірний номер задачі!");
                    break;

            }
            Console.ReadLine();
                        
        }
    }
}

