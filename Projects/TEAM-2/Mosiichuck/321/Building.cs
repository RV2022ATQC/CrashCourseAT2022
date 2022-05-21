using System;

namespace _321
{
    public abstract class Building
    {
        private string address;
        private DateTime dateOfCommissioning;
        public string Address { get; set; }
        public DateTime DateOfCommissioning { get; set; }

        public Building(string address, string dateOfCommissioning)
        {
            Address = address;
            DateOfCommissioning = DateTime.Parse(dateOfCommissioning);
        }

        public Building()
        {
            Address = "";
            DateOfCommissioning = DateTime.Now;
        }

        public override string ToString()
        {
            return Address;
        }

        public abstract void Input();
        public abstract void Output();
    }
}
