using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task301.Classes
{
    public class Shop
    {
        private List<Product> products;

        public int getSize()
        {
            return products.Count;
        }
        public List<Product> GetList()
        {
            return products;
        }

        public Shop()
        {
            products = new List<Product>();
        }

        public void addProduct(Product item)
        {
            products.Add(item);
        }

        public void deleteProd(int id)
        {
            var delProduct = products.FirstOrDefault(x => id == x.getId());
            products.Remove(delProduct);
        }

        public void printList()
        {
            foreach (var item in products)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(" -----------------------------------------");
        }


    }
}
