using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minimum_Concatenation;
using Minimum_Concatenation_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString1 = utility.GetValidString("first");
            var userString2 = utility.GetValidString("second");
            var minimum = utility.GetMinimum(userString1, userString2);
            var newString = utility.CreateNewString(userString1, userString2, minimum);
            Message.DisplayNewString(newString);
            Console.ReadLine();
        }
    }
}
