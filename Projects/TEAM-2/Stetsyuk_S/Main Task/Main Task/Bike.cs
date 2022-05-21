using System.Xml.Serialization;

namespace final_task
{
    [Serializable]
    public class Bike : Vehicle
    {
        public Bike() { }

        public Bike(string Brand, uint Year_of_production, string Model) : base(Brand, Year_of_production, Model) { }

        public override string ToString()
        {
            return ("Bike" + "\tBrand: " + Brand + "\tModel: " + Model + "\tYear of production: " + Year_of_production);
        }

        public override bool Equals(object? obj)
        {
            return (obj as Bike)?.Brand == this.Brand &&
                   (obj as Bike)?.Model == this.Model &&
                   (obj as Bike)?.Year_of_production == this.Year_of_production;
        }
    }
}
