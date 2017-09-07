using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Roster
{
    public enum Department { Accounting, IT, Sales, Human_Resources, Customer_Service, Product_Development, Custodial}
    public class Employee : Person
    {
        public string Job_Title { get; set; }

        public Department Department { get; set; }

        public double Yearly_Salary { get; set; }
    }
}
