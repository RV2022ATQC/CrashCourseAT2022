// Мерцалова Ірина, Мосійчук Юрій
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public class Order
    {
        private int id;
        private DateTime date;
        private bool status;

        public int Id 
        {
            get { return id; }
            set { id = value; } 
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
