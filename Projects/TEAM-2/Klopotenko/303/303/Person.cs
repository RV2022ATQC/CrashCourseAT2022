using System;
namespace _303
{
    public class Person
    {
        public string name;
        public int age;
        public string sex;
        public string mobilePhone;
        public string SetName (string _name)
        {
            name = _name;
            return name;
        }
        public string GetName()
        {
            return name;
        }
        public int SetAge(int _age)
        {
            if (_age > 0 && _age <= 120)
            {
                age = _age;
                return age;
            }
            else
            {
                Random randon = new Random();
                int a = randon.Next(0, 120);
                age = a;
                Console.WriteLine($"Age must be from 0 to 120! Setted random age = {a}!");
                return age;
            }
        }
        public int GetAge()
        {
            return age;
        }
        public string SetSex(string _sex)
        {
            if (_sex == "Male" || _sex == "Female")
            {
                sex = _sex;
                return sex;
            }
            else
            {
                Random randon = new Random();
                int a = randon.Next(0, 2);
                if (a == 0) { _sex = "Male"; }
                else { _sex = "Female"; }
                sex = _sex;
                Console.WriteLine($"Sex must be Male or Female. Setted sex = {_sex}");
                return sex;
            }
        }
        public string GetSex()
        {
            return sex;
        }
        public string SetMobilePhone(string _mobilePhone)
        {
            mobilePhone = _mobilePhone;
            return mobilePhone;
        }
        public string GetMobilePhone()
        {
            return mobilePhone;
        }
        public Person(string _name, int _age, string _sex, string _mobilePhone)
        {
            this.name = SetName(_name);
            this.age = SetAge(_age);
            this.sex = SetSex(_sex);
            this.mobilePhone = SetMobilePhone(_mobilePhone);
        }
        public void Print()
        {
            Console.WriteLine($"Person info:\nName: {GetName()}\nAge: {GetAge()}\nSex: {GetSex()}\nPhone number: {GetMobilePhone()}");
        }
    }
}
