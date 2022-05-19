using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task303
{
    public class Person
    {
        // fields
        private string name;
        private int age;
        private string sex;
        private string phone;

        #region properties
        public string getName()
        {
            return this.name;
        }
        public void setName(string _name)
        {
            this.name = _name;
        }

        public int getAge()
        {
            return this.age;
        }
        public void setAge(int _age)
        {
            if (_age <= -1)
            {
                this.age = 0;
            }
            else
            {
                this.age = _age;
            }
        }

        public string getSex()
        {
            return this.sex;
        }
        public void setSex(string _sex)
        {
            if (_sex == "woman" || _sex == "man")
            {
            this.sex = _sex;
            }
            else
            {
                this.sex = "unknown";
            }
        }

        public string getPhone()
        {
            return this.phone;
        }
        public void setPhone(string _phone)
        {
            var isNumeric = int.TryParse(_phone, out _);
            if (isNumeric)
            {
                this.phone = _phone;
            }
            else
            {
                this.phone = "+000000000000";
            }
        }

        #endregion

        public Person(string _name, 
            int _age, 
            string _sex, 
            string _phone)
        {
            setName(_name);
            setAge(_age);
            setSex(_sex);
            setPhone(_phone);
        }

        public void Print()
        {
            Console.WriteLine(" -----------------------------------------" +
                "\n   Name: " + this.name +
                "\n   Age: " + this.age +
                "\n   Sex: " + this.sex +
                "\n   Phone: " + this.phone);
        }
    }
}
