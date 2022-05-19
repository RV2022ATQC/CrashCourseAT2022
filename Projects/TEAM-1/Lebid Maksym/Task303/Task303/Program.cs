using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task303
{
    internal class Program
    {
        //Розробити клас Person, який містить відповідні члени для зберігання:
        //імені, віку, статі і телефонного номера.
        //Напишіть функції-члени, які зможуть змінювати ці члени даних індивідуально.
        //Напишіть функцію-член Person :: Print (), яка виводить відформатовані дані про людину.
        class Person
        {
            public string name;
            public int age;
            public int sex;
            public float teleph;
            public Person(string name, int age, int sex, float teleph)
            {
                this.name = name;
                this.age = age;
                this.sex = sex;
                this.teleph = teleph;
            }

            public Person()
            {
                this.name = null;
                this.age = 0;
                this.sex = -1;
                this.teleph = 0;
            }

            public string GetString()
            {
                Console.WriteLine("Enter text: ");
                string tempstr = Console.ReadLine();
                while (tempstr.Length == 0)
                {
                    Console.WriteLine("Enter text: ");
                    tempstr = Console.ReadLine();
                }
                return tempstr;
            }

            public int GetInt()
            {
                int temp = 0;
                bool isCorret = false;
                while(isCorret == false)
                {
                    try
                    {
                        Console.WriteLine("Enter number:");
                        temp = int.Parse(Console.ReadLine());
                        if (temp >= 0)
                        {
                            isCorret = true;
                        }
                        else
                        {
                            Console.WriteLine("Person`s age can`t be less than 0!");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Wrong input!");
                    }
                }
                return temp;
            }

            public int GetInt(int other)
            {
                int temp = 0;
                bool isCorret = false;
                while (isCorret == false)
                {
                    try
                    {
                        Console.WriteLine("Enter number:");
                        temp = int.Parse(Console.ReadLine());
                        isCorret = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Wrong input!");
                    }
                }
                return temp;
            }

            public int GetSex()
            {
                int temp = -1;
                bool isCorret = false;
                while (isCorret == false)
                {
                    try
                    {
                        Console.WriteLine("Enter sex, 1 for man, 0 for woman: ");
                        temp = int.Parse(Console.ReadLine());
                        if (temp == 1 || temp == 0)
                        {
                            isCorret = true;
                        }

                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Wrong input!");
                    }
                }
                return temp;
            }

            public float GetFloat()
            {
                float temp = 0;
                bool isCorret = false;
                while (isCorret == false)
                {
                    try
                    {
                        Console.WriteLine("Enter number:");
                        temp = float.Parse(Console.ReadLine());
                        isCorret = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Wrong input!");
                    }
                }
                return temp;
            }

            public void SetName()
            {
                string newName = GetString();
                this.name = newName;
                Console.WriteLine("Changed succesfuly");
            }

            public void SetAge()
            {
                int newAge = GetInt();
                this.age = newAge;
                Console.WriteLine("Changed succesfuly");
            }

            public void SetSex()
            {
                int newSex = GetSex();
                this.sex = newSex;
                Console.WriteLine("Changed succesfuly");
            }

            public void SetTeleph()
            {
                float newTeleph = GetFloat();
                this.teleph = newTeleph;
            }

            public void ShowInfo()
            {
                Console.Write("Person: ");
                if (this.name != null)
                {
                    Console.Write($"{name}, ");
                }
                else { Console.Write("No name, "); }


                if (this.age != 0)
                {
                    Console.Write($"{age}, ");
                }
                else { 
                    Console.Write("no age, "); 
                    }


                if (this.sex == 0)
                {
                    Console.Write("woman, ");
                }
                else if (this.sex == 1)
                {
                    Console.Write("man, ");
                }
                else { 
                    Console.Write("no sex, "); 
                    }


                if(this.teleph != 0)
                {
                    Console.WriteLine($"{teleph}.");
                }
                else { 
                    Console.WriteLine("no teleph.");
                    }
            }
        }
        static void Main(string[] args)
        {
            Person Stranger = new Person();
            int choose = 1;
            Console.WriteLine("Enter 1 for changing name, 2 for age, 3 for sex, 4 for telephone number and 5 for showing you info, 0 for exit:");
            while (choose != 0)
            {
                choose = Stranger.GetInt(0);
                if (choose == 1)
                {
                    Stranger.SetName();
                }
                else if (choose == 2)
                {
                    Stranger.SetAge();
                }
                else if (choose == 3)
                {
                    Stranger.SetSex();
                }
                else if (choose == 4)
                {
                    Stranger.SetTeleph();
                }
                else if (choose == 5)
                {
                    Stranger.ShowInfo();
                }
            }
        }
    }
}
