namespace _301
{
    public class Item
    {
        public Item(string name, double price, string creator, uint quantity)
        {
            if (!String.IsNullOrWhiteSpace(name))
                this.name = name;
            else
                this.name = "NoN";
            this.price = price;
            if (!String.IsNullOrWhiteSpace(creator))
                this.creator = creator;
            else
                this.creator = "NoN";
            this.quantity = quantity;
            counter++;
            ID = counter;
        }

        private static uint counter = 0;

        public uint ID { get; }
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    name = value;
            }
        }

        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
            }
        }

        private string creator;
        public string Creator
        {
            get { return creator; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    name = value;
            }
        }

        private uint quantity;
        public uint Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public override string ToString()
        {
            return ("ID: " + ID + "\tName: " + Name + "\tCreator: " + Creator + "\tPrice: " + Price + "\tQuantity: " + Quantity);
        }
    }
}
