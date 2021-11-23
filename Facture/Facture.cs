using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture
{
    public class Facture
    {
        internal int Id;

        public string Reference { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Qte { get; set; }
        public string Name_Client { get; set; }
        public string Tel { get; set; }

        public double Total { get { return Price * Qte; } }

        public Facture(string reference, string name, double price, double qte, string name_client, string tel)
        {
            Reference = reference;
            Name = name;
            Price = price;
            Qte = qte;
            Name_Client = name_client;
            Tel = tel;
            
        }

        public Facture()
        {
        }
    }
}
