using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task301.Classes
{
    public class Product
    {
        // fields
        private int id;
        private string name;
        private float price;
        private string description;
        private string articul;

        #region properties

        public int getId()
        {
            return this.id;
        }
        public void setId(int _id)
        {
            if (_id <= -1)
            {
                this.id = 0;
            }
            else
            {
                this.id = _id;
            }
        }
        public string getName()
        {
            return this.name;
        }
        public void setName(string _name)
        {
            this.name = _name;
        }
        public float getPrice()
        {
            return this.price;
        }
        public void setPrice(float _price)
        {
            if (_price <= -1)
            {
                this.price = 0;
            }
            else
            {
                this.price = _price;
            }
        }
        public string getDescription()
        {
            return this.description;
        }
        public void setDescription(string _description)
        {
            this.description = _description;
        }
        public string getArticul()
        {
            return this.articul;
        }
        public void setArticul(string _articul)
        {
            this.articul = _articul;
        }

        #endregion

        public Product() { }

        public Product(int _id,
            string _name,
            float _price,
            string _description,
            string _articul)
        {
            setId(_id);
            setName(_name);
            setPrice(_price);
            setDescription(_description);
            setArticul(_articul);
        }

        public override string ToString()
        {
            return " -----------------------------------------" +
                "\n   Id: " + this.id +
                "\n   Name: " + this.name +
                "\n   Price: " + this.price +
                "\n   Description: " + this.description +
                "\n   Articul: " + this.articul;
        }
    }
}
