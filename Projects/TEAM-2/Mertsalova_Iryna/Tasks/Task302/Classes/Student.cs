using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task302.Classes
{
    public class Student
    {
        // fields
        private int id;
        private string surname;
        private string name;
        private int math;
        private int language;
        private int chemistry;
        private int biology;

        public Student() { }
        public Student(int id,
            string surname,
            string name,
            int math,
            int language,
            int chemistry,
            int biology)
        {
            setId(id);
            setSurname(surname);
            setName(name);
            setMath(math);
            setLanguage(language);
            setChemistry(chemistry);
            setBiology(biology);
        }

        #region properties

        public int getId()
        {
            return id;
        }
        public void setId(int _id)
        {
            this.id = _id;
        }

        public string getSurname()
        {
            return surname;
        }
        public void setSurname(string _surname)
        {
            this.surname = _surname;
        }

        public string getName()
        {
            return name;
        }
        public void setName(string _name)
        {
            this.name = _name;
        }

        public int getMath()
        {
            return math;
        }
        public void setMath(int _math)
        {
            this.math = _math;
        }

        public int getLanguage()
        {
            return language;
        }
        public void setLanguage(int _language)
        {
            this.language = _language;
        }

        public int getChemistry()
        {
            return chemistry;
        }
        public void setChemistry(int _chemistry)
        {
            this.chemistry = _chemistry;
        }

        public int getBiology()
        {
            return biology;
        }
        public void setBiology(int _biology)
        {
            this.biology = _biology;
        }

        #endregion

        public override string ToString()
        {
            return " -----------------------------------------------------------" +
                "\n   Id: " + this.id +
                "\n   Student: " + this.surname + " " + this.name +
                "\n   Marks: \n" +
                "    Math -> " + this.math + "; Language -> " + this.language + "; Chemistry -> " + this.chemistry + "; Biology -> " + this.biology;
        }
    }
}
