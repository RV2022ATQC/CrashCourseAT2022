using System;
using System.Collections.Generic;
using System.Linq;

namespace _301
{
    class Shop
    {
        private List<Product> products;
        public Shop()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine("Product was added!");
        }
        public void DeleteProduct(int Id)
        {
            var product = products.FirstOrDefault(x => x.Id == Id);
            if(product != null)
            {
                products.Remove(product);
                Console.WriteLine("Product was deleted!");
            }
            else
                Console.WriteLine("Wrong Id!");
        }
        public void ShowProducts()
        {
            foreach (var item in products)
            {
                Console.WriteLine(item.Id+" "+item.Name +" "+ item.Price+"$");
            }
        }
    }
}
