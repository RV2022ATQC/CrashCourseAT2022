using System.Xml.Serialization;

namespace final_task
{
    [Serializable()]
    [System.Xml.Serialization.XmlInclude(typeof(Vehicle))]
    [System.Xml.Serialization.XmlInclude(typeof(Car))]
    [System.Xml.Serialization.XmlInclude(typeof(Bus))]
    [System.Xml.Serialization.XmlInclude(typeof(Bike))]
    public abstract class Vehicle : IComparable<Vehicle>
    {
        public Vehicle() { }
        public Vehicle(string Brand, uint Year_of_production, string Model)
        {
            if (!string.IsNullOrWhiteSpace(Brand))
                this.Brand = Brand;
            else this.Brand = "null";

            this.Year_of_production = Year_of_production;

            if (!string.IsNullOrWhiteSpace(Model))
                this.Model = Model;
            else this.Brand = "null";
        }

        [XmlElement()]
        private string brand;
        public string Brand
        {
            get { return brand; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    brand = value;
            }
        }

        [XmlElement()]
        private string model;
        public string Model
        {
            get { return model; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    model = value;
            }
        }

        [XmlElement()]
        public uint Year_of_production { get; set; }

        public int CompareTo(Vehicle? other)
        {
            return this.Brand.CompareTo(other?.Brand);
        }

        public bool Older_then_10()
        {
            return ((DateTime.Now.Year - this.Year_of_production) >= 10);
        }

        public abstract override bool Equals(object? obj);
    }
}
