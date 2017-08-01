using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentimetersToInches;
using CentimetersToInches_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var centimeters = utility.GetValidEntry();
            var inches = utility.GetInches(centimeters);
            Message.DisplayInches(centimeters, inches);
            Console.ReadLine();
        }
    }
}
