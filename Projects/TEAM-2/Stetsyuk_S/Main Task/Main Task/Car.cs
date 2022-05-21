using System.Xml.Serialization;

namespace final_task
{
    [Serializable]
    public class Car : Vehicle
    {
        public Car() { }

        public Car(string Brand, uint Year_of_production, string Model, uint Race) : base(Brand, Year_of_production, Model)
        {
            this.Race = Race;
        }

        [XmlElement()]
        public uint Race { get; set; }

        public override string ToString()
        {
            return ("Car" + "\tBrand: " + Brand + "\tModel: " + Model + "\tYear of production: " + Year_of_production + "\tRace: " + Race);
        }

        public override bool Equals(object? obj)
        {
            return (obj as Car)?.Brand == this.Brand &&
                   (obj as Car)?.Model == this.Model &&
                   (obj as Car)?.Year_of_production == this.Year_of_production &&
                   (obj as Car)?.Race == this.Race;
        }
    }
}
