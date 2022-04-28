using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex_303
{   
    //"Розробити клас Person, який містить відповідні члени для зберігання: імені, віку, статі і телефонного номера.
        //Напишіть функції-члени, які зможуть змінювати ці члени даних індивідуально.
        //Напишіть функцію-член Person :: Print (), яка виводить відформатовані дані про людину."
    class Person
    {
        private string name;
        private int age;
        private bool sex;//true - man \ false - woman
        private string pNumber;
        public Person(string _name, int _age, string _sex,string _pNumber )
        {
            name = _name;
            age = _age;
            sex = _sex.Equals("man") ? true : false;
            pNumber = _pNumber;
        }
        public Person(string _name)
        {
            name = _name;
            age = -1;
            sex = true;
            pNumber = "undefined";
        }
        public Person()
        {
        }
        public int EnterNumber()// my funk for correct manual inputing integer
        {
            string tempStr;
            int number = 0;
            bool isComplate = false;
            while (!isComplate)
            {
                tempStr = Console.ReadLine();
                try
                {
                    number = int.Parse(tempStr);
                    if (number >= 0)
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

        public string EnterString()// my funk for correct manual inputing string
        {
            string tempStr = Console.ReadLine();
            while (tempStr.Length==0)
            {
                Console.WriteLine("Wrong input, try again");
                tempStr = Console.ReadLine();
            }
            return tempStr;
        }///

    
        public void SetpNumber(string phone = null)///phone number
        {
            if (phone == null)
            {
                Console.WriteLine("Enter phone number (+380_):");
                phone = EnterNumber().ToString();
            }
                while(phone.Length!=9)
            {
                Console.WriteLine("Wrong input number, enter 9 digit without (+380_):");
                phone = EnterNumber().ToString();
            }
            pNumber = phone;
        }
        public string GetpNumber()
        {
            return pNumber;
        }///
        public void SetSex(string sexStr = null)///sex
        {
            if (sexStr == null)
            {
                Console.WriteLine("Enter sex ('man' or 'woman'):");
                sexStr = EnterString();
            }
                bool isComplate = false;
            while (!isComplate)//converting string to bool
            {
                if (sexStr.Equals("man"))
                {
                    sex = true;
                    isComplate = true;
                }
                else if (sexStr.Equals("woman"))
                {
                    sex = false;
                    isComplate = true;
                }
                else
                {
                    Console.WriteLine("Wrong input sex, enter 'man' or 'woman':");
                    sexStr = EnterString();
                }
            }
        }
        public string GetSex()
        {
            return sex ? "man" : "woman";//convert bool to string
        }///
        public void SetAge(int age = -1)///age
        {
            while (age <= 0)//must be positive
            {
                Console.WriteLine("Enter age:");
                age = EnterNumber();
            }
                this.age = age;
        }
        public int GetAge()
        {
            return age;
        }///
        public void SetName()///name
        {
            Console.WriteLine("Enter name:");
            name = EnterString();
        }
        public string GetName()
        {
            return name;
        }///

        public void Print()
        {
            Console.WriteLine($"name: {name}, age: {age}, sex: {GetSex()}, phone number: +380{pNumber}\n");
        }

    }

    class Program
    {
        static Person fill()//is required to test class//must be deleted
        {
            return new Person("Bylgakow",43,"man","975476745");
        }


        static void Main(string[] args)
        {
            Person person = new Person();
            int varriant = -1;

            
            person = fill();//only for development


            Console.WriteLine("Print:\n\n1  -  to print person\n2  -  to change data\n0  -  to EXIT");
            while (varriant != 0)//manual menu
            {
                varriant = person.EnterNumber();

                if (varriant == 1)
                    person.Print();
                else if (varriant == 2)
                {
                    int varForChange = -1;
                    Console.WriteLine("Print:\n\n1  -  to change name\n2  -  to change age\n3  -  to change sex\n4  -  to change phone number\n0  -  to return to the menu");
                    while (varForChange != 0)//manual menu
                    {
                        varForChange = person.EnterNumber();
                        if (varForChange == 1)
                        {
                            person.SetName();
                            varForChange = 0;
                        }
                        else if (varForChange == 2)
                        {
                            person.SetAge();
                            varForChange = 0;
                        }
                        else if (varForChange == 3)
                        {
                            person.SetSex();
                            varForChange = 0;
                        }
                        else if (varForChange == 4)
                        {
                            person.SetpNumber();
                            varForChange = 0;
                        }

                        else if(varForChange!=0)//check correct input
                            Console.WriteLine("Wrong input, try again(0-4)");
                    }
                }
                else
                    Console.WriteLine("Error, wrong input, try again(0-2)");

                Console.WriteLine("Print your choose (0 - 2):");
            }///
        }
    }
}
