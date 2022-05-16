//Стецюк Софія

using System;

namespace GroupProject
{
    public class Item : IComparable
    {
        public Item(string name, double price, string creator, uint quantity)
        {
            //this.name = name;
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

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Item))
                return false;
            return (this.Name == (obj as Item)?.Name) &&
                (this.Price == (obj as Item)?.Price) &&
                (this.Quantity == (obj as Item)?.Quantity) &&
                (this.Creator == (obj as Item)?.Creator) &&
                (this.ID == (obj as Item)?.ID);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Creator.GetHashCode() ^ Price.GetHashCode() ^ Quantity.GetHashCode() ^ ID.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            return Name.CompareTo((obj as Item)?.Name);
        }
    }
}
