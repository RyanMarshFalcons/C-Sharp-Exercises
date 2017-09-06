using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Roster
{
    public class Manager : Employee
    {
        public int Number_Of_Staff { get; set; }

        public double Total_Department_Costs { get; set; }

        public double Total_Department_Revenue { get; set; }

        public string Company_Credit_Card_Number { get; set; }

        public int Compliance_Violations_This_Year { get; set; }
    }
}
