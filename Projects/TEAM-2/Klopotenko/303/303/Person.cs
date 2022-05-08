using System;
namespace _303
{
    public class Person
    {
        public string name;
        public int age;
        public string sex;
        public string mobilePhone;
        public void SetName (string _name)
        {
            name = _name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetAge(int _age)
        {
            if (_age > 0 && _age <= 120)
            {
                age = _age;
            }
            else
            {
                Random randon = new Random();
                int a = randon.Next(0, 120);
                age = a;
                Console.WriteLine($"Age must be from 0 to 120! Setted random age = {a}!");
            }
        }
        public int GetAge()
        {
            return age;
        }
        public void SetSex(string _sex)
        {
            if (_sex == "Male" || _sex == "Female")
            {
                sex = _sex;
            }
            else
            {
                Random randon = new Random();
                int a = randon.Next(0, 2);
                if (a == 0) { _sex = "Male"; }
                else { _sex = "Female"; }
                sex = _sex;
                Console.WriteLine($"Sex must be Male or Female. Setted sex = {_sex}");
            }
        }
        public string GetSex()
        {
            return sex;
        }
        public void SetMobilePhone(string _mobilePhone)
        {
            mobilePhone = _mobilePhone;
        }
        public string GetMobilePhone()
        {
            return mobilePhone;
        }
        public Person(string _name, int _age, string _sex, string _mobilePhone)
        {
            this.name = _name;
            if (_age > 0 && _age <= 121)
            {
                this.age = _age;
            }
            else
            {
                Random randon = new Random();
                int a = randon.Next(0, 121);
                this.age = a;
                Console.WriteLine($"Age must be from 0 to 120! Setted random age = {a}!");
            }
            if (_sex == "Male" || _sex == "Female")
            {
                this.sex = _sex;
            }
            else
            {
                Random randon = new Random();
                int a = randon.Next(0, 2);
                if (a == 0) { _sex = "Male"; }
                else { _sex = "Female"; }
                this.sex = _sex;
                Console.WriteLine($"Sex must be Male or Female. Setted sex = {_sex}");
            }
            this.mobilePhone = _mobilePhone;
        }
        public void Print()
        {
            Console.WriteLine($"Person info:\nName: {GetName()}\nAge: {GetAge()}\nSex: {GetSex()}\nPhone number: {GetMobilePhone()}");
        }
    }
}
