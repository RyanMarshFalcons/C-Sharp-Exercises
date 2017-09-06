using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Roster
{
    public class Customer : Person
    {
        public DateTime Initial_Purchase { get; set; }

        public DateTime Most_Recent_Purchase { get; set; }

        public int Total_Number_Of_Purchases { get; set; }

        public double Total_Spent_On_Purchases { get; set; }

        public string Credit_Card_Number { get; set; }

        public string Billing_Address { get; set; }

        public string Shipping_Address { get; set; }
        
        int Employee_ID_Number { get; set; }
    }
}
