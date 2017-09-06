using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Roster
{
    public class Employee : Person
    {
        public string Job_Title { get; set; }

        public double Yearly_Salary { get; set; }

        public string Department { get; set; }

        public string Immediate_Supervisor { get; set; }

        public DateTime Hire_Date { get; set; }

        public int Remaining_Sick_Days { get; set; }

        public int Remaining_Vacation_Days { get; set; }

        public int Remaining_Personal_Days { get; set; }

        public int Employee_ID_Number { get; set; }
    }
}
