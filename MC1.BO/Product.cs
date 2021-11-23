using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC1.BO
{
    public class Product
    {
        public string Reference { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public int Quantity { get; set; }

        public Product()
        {

        }

        public Product(string reference, string name, double price, int q)
        {
            Reference = reference;
            Name = name;
            Price = price;
            Quantity = q;
        }

        public Product(Product product) : this(product?.Reference, product?.Name, product?.Price ?? 0, product.Quantity)
        {

        }

        public override bool Equals(object obj)
        {
            return obj is Product product &&
                   Reference == product.Reference;
        }

        public override int GetHashCode()
        {
            return -1304721846 + EqualityComparer<string>.Default.GetHashCode(Reference);
        }
    }
}
