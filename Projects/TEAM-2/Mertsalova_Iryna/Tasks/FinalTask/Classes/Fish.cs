using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask.Classes
{
    public class Fish : Animal
    {
        private string kind;
        private string species;

        #region Getters_Setters

        public string getKind() { return this.kind; }
        public void setKind(string _kind)
        {
            if(_kind == "sea" || _kind == "river")
            {
                this.kind = _kind;
            }
            else
            {
                this.kind = "river";
            }
        }
        public string getSpecies() { return this.species; }
        public void setSpecies(string _species) { this.species = _species; }

        #endregion

        public Fish() { }

        public Fish(string _name, int _birth_year, string _animal_color, string _kind, string _species) : base(_name, _birth_year, _animal_color)
        {
            setKind(_kind);
            setSpecies(_species);
        }

        public override void fill()
        {
            base.fill();
            Console.Write($" Enter the kind of the {GetType().Name} (sea or river): ");
            string kind = Console.ReadLine();
            Console.Write($" Enter the species of the {GetType().Name}: ");
            string species = Console.ReadLine();

            setKind(kind);
            setSpecies(species);
        }

        public override string print()
        {
            return $"{base.print()}" +
                $"   Kind: {getKind()}" +
                $"\n   Species: {getSpecies()}" +
                $"\n";
        }

        public override string ToString()
        {
            return $"{print()}   Voice: {voice()}\n";
        }

        public override string voice()
        {
            return "~ fish-fish-fish ~";
        }

    }
}
