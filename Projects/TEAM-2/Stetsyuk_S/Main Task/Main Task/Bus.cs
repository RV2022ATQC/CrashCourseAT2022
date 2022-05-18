using System.Xml.Serialization;

namespace final_task
{
    [Serializable]
    public class Bus : Vehicle
    {
        public Bus() { }

        public Bus(string Brand, uint Year_of_production, string Model, uint Race) : base(Brand, Year_of_production, Model)
        {
            this.Race = Race;
        }

        [XmlElement()]
        public uint Race { get; set; }

        public override string ToString()
        {
            return ("Bus" + "\tBrand: " + Brand + "\tModel: " + Model + "\tYear of production: " + Year_of_production + "\tRace: " + Race);
        }
        public override bool Equals(object? obj)
        {
            return (obj as Bus)?.Brand == this.Brand &&
                   (obj as Bus)?.Model == this.Model &&
                   (obj as Bus)?.Year_of_production == this.Year_of_production &&
                   (obj as Bus)?.Race == this.Race;
        }
    }
}
