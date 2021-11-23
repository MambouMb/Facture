using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture
{
    public class RptUserList
    {
        public string  Email { get; set; }
        public string Fullname { get; set; }

        public RptUserList(string email, string fullname)
        {
            Email = email;
            Fullname = fullname;
        }
    }
}
