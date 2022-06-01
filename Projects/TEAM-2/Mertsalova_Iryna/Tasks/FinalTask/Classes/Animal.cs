using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask.Classes
{
    public class Animal
    {
        // fields
        private string name;
        private int birth_year;
        private string animal_color;

        #region Getters_Setters

        public int getBirthYear() { return this.birth_year; }
        public void setBirthYear(int _year)
        {
            if ((_year > 1990) && (_year <= DateTime.Now.Year))
            {
                this.birth_year = _year;
            }
            else
            {
                this.birth_year = DateTime.Now.Year;
            }
        }
        public string getAnimalColor() { return this.animal_color; }
        public void setAnimalColor(string _color) { this.animal_color = _color; }
        public string getName() { return this.name; }
        public void setName(string _name) { this.name = _name; }
        public int getAge() { return DateTime.Now.Year - this.birth_year; }

        #endregion

        public Animal() { } // ctor without param
        
        public Animal(string _name, int _birth_year, string _animal_color) // ctor with param
        {
            setName(_name);
            setBirthYear(_birth_year);
            setAnimalColor(_animal_color);
        }

        public virtual void fill() // function for input fields
        {
            Console.Write($" Enter the name of the {GetType().Name}: ");
            string name = Console.ReadLine();
            Console.Write($" Enter the year of the {GetType().Name}: ");
            int year = Int32.Parse(Console.ReadLine());
            Console.Write($" Enter the color of the {GetType().Name}: ");
            string color = Console.ReadLine();

            setName(name);
            setBirthYear(year);
            setAnimalColor(color);
        }

        public virtual string voice()
        {
            return "~ animal-animal-animal ~";
        }

        public virtual string print() // function for output fields
        {
            return $"  {GetType().Name}:" +
                $"\n   Name: {getName()}" +
                $"\n   Birth year: {getBirthYear()}" +
                $"\n   Age: {getAge()}" +
                $"\n   Color: {getAnimalColor()}" +
                $"\n";
        }

        public override string ToString()
        {
            return $"{print()}   Voice: {voice()}\n";
        }
    }
}
