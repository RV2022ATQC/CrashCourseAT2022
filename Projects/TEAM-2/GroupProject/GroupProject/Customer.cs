// Максим Циганчук
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public class Customers
    {
       public string Name;
       public float money;

       public Customers(string Name, float money)
        {
            this.Name = Name;
            this.money = money;
        }
       
    public string Set_Name(string Name)
        {
            this.Name = Name;

            return Name.ToString();
        }

    public float Set_money(float money)
        {
            this.money = money;

            return money.ToString();
        }

     Customers new_customer = new Customers();
    }
}
