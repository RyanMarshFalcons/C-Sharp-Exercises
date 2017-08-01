using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InchesToCentimeters;
using InchesToCentimeters_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var inches = utility.GetValidEntry();
            var centimeters = utility.GetCentimeters(inches);
            Message.DisplayCentimeters(inches, centimeters);
            Console.ReadLine();
        }
    }
}
