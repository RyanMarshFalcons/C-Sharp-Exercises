﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Roster
{
    public class Person
    {
        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public string Email_Address { get; set; }

        public string Home_Address { get; set; }

        public string Phone_Number { get; set; }

        public string Full_Name()
        {
            return First_Name + " " + Last_Name;
        }
    }
}
