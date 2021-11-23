using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC1.BO
{
    public class User
    {


        public string Fullname { get; set; }
        public string phone_number { get; set; }

        public List<Product> Products { get; set; }

        public User()
        {
            Products = new List<Product>();
        }

        public User(string fullname) : this()
        {
            
            Fullname = fullname;
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        public List<Product> GetProducts()
        {
            var list = new List<Product>();
            foreach (var p in Products)
                list.Add(new Product(p));
            return list;
        }

        
    }
}
