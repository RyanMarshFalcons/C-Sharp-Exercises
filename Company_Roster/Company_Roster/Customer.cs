using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Roster
{
    public class Customer : Person
    {
       public string Credit_Card_Number { get; set; }

        public string Billing_Address { get; set; }

        public string Shipping_Address { get; set; }
    }
}
