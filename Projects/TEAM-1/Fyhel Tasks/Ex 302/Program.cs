using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_302
{
    //Написати клас Студент. Також реалізувати клас, що описує групу студентів.
    //Передбачити можливість визначення середньої успішності групи за певним предметом.
     class Student
    {
        public int EnterNumber()// my funk for correct manual inputing integer
        {
            string tempStr ;
            int number = 0;
            bool isComplate = false;
            while (!isComplate )
            {    
                tempStr = Console.ReadLine();
                try
                {
                    number = int.Parse(tempStr);
                    if(number>=0)
                    isComplate = true;
                    else
                        Console.WriteLine("Error, number must be positive, try again");
                }
                catch 
                {
                    Console.WriteLine("Wrong input, try again");
                }
            }
            return number;
        }///

        public Student()//empy constructor
        {
        }///
        public Student(int id, string name, int algebra, int programing, int english, int mathAnalith)//fully filled constructor 
        {
            this.id = id;
            this.name = name;
            this.algebra = algebra;
            this.programing = programing;
            this.english = english;
            this.mathAnalith = mathAnalith;
        }///

        public int id;
        public string name;
        public int algebra;
        public int programing;
        public int english;
        public int mathAnalith;

        public string getStudent()//return student in string 
        {
            return id + " " + name + ", algebra: " + algebra + ", programing: " + programing + ", english: " + english + ", math analith: " + mathAnalith;
        }///
    }

    class Group:Student
    {
        private List<Student> allStudents = new List<Student>();
       
        //SETTERS
        public void AddStudent(Student student)//if fynction give ready student//is used for development
        {
            allStudents.Add(student);
        }///
        public void AddStudent(int id)//if fynction don't give student parametr//manual input
        {
            Student student = new Student();
                                
            student.id = id+1;
            Console.WriteLine("Enter name:");
            student.name = Console.ReadLine();
            Console.WriteLine("Enter algeba:");
            student.algebra = EnterNumber();
            Console.WriteLine("Enter programing:");
            student.programing = EnterNumber();
            Console.WriteLine("Enter english:");
            student.english = EnterNumber();
            Console.WriteLine("Enter math analith:");
            student.mathAnalith = EnterNumber();

            allStudents.Add(student);
        }///
        public void DeleteStudent()//erasing student by number id
        {
            Console.WriteLine("Enter number of student which one you want to delete:");
            int numOfSt = EnterNumber()-1;
            while(numOfSt >= allStudents.Count||numOfSt<0)
            {
                Console.WriteLine("There is no such student, try again:");
                numOfSt = EnterNumber()-1;
            }
            allStudents.RemoveAt(numOfSt);

            for (int i = 0; i < allStudents.Count; i++)
                allStudents[i].id=i+1;
        }///
        
        //GETTERS:
        public int GetLength()//return length of group
        {
            return allStudents.Count;
        }///
        public void PrintAllStudents()//print in console all students
        {
            foreach(var i in allStudents)
            Console.WriteLine(i.getStudent());
            if (allStudents.Count == 0)//if group is empty
                Console.WriteLine("Your group is empty :(((");
            Console.WriteLine("\n");
        }///
        public double GetAverageInGroup()///return average 
        {
            Console.WriteLine("\n\nPrint to get average:\n\n1  -  from algebra\n2  -  from programing\n3  -  from english\n4  -  from math analith");
            int subject = EnterNumber();
            double avg = 0;

            if (subject == 1)//algebra
                foreach (var i in allStudents)
                    avg += i.algebra;
            else if (subject == 2)//programing
                foreach (var i in allStudents)
                    avg += i.programing;
            else if (subject == 3)//english
                foreach (var i in allStudents)
                    avg += i.english;
            else if (subject == 4)//mathAnalith
                foreach (var i in allStudents)
                    avg += i.mathAnalith;
            else
                Console.WriteLine("Error, wrong choose of subject");

            return avg/allStudents.Count;
        }///
    }

    class Program
    {

        static Group fillGroup(Group allStudents)//only for development//automatic filling
        {
            allStudents.AddStudent(new Student(1, "Vargo", 3, 4, 1, 2));
            allStudents.AddStudent(new Student(2, "Pengy", 5, 5, 4, 3));
            allStudents.AddStudent(new Student(3, "Zero", 2,3, 5, 4));

            return allStudents;
        }///

        static void Main(string[] args)
        {
            Group group = new Group();//our group
            group = fillGroup(group);//automatic filling the group
            group.PrintAllStudents();

            int varriant = -1;
            Console.WriteLine("Print:\n\n0  -  to print all group\n1  -  to add student to group\n2  -  to delete student\n3  -  to get average in one subject\n4  -  EXIT");
            while (varriant != 4)//manual menu
            {
                    varriant = group.EnterNumber();

                if (varriant == 0)
                    group.PrintAllStudents();
                else if (varriant == 1)
                    group.AddStudent(group.GetLength());

                else if (group.GetLength() != 0)//checking if there is students in group
                {
                    if (varriant == 2)
                        group.DeleteStudent();
                    else if (varriant == 3)
                        Console.WriteLine($"It is {group.GetAverageInGroup()} avarage mark in group.");
                    else//check correct input
                        Console.WriteLine("Wrong input, try again");
                }
                else
                        Console.WriteLine("Error there is no students in group");

                Console.WriteLine("Print your choose:");
            }///
        }
    }
}
