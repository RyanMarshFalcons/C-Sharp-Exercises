using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XY_Balance;
using XY_Balance_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetValidString();
            var xCount = utility.GetCount(userString, "x");
            var XCount = utility.GetCount(userString, "X");
            var yCount = utility.GetCount(userString, "y");
            var YCount = utility.GetCount(userString, "Y");
            if (utility.CheckIfBalance(xCount, XCount, yCount, YCount))
            {
                Message.WasXYalance();
            }
            else
            {
                Message.WasNotXYalance();
            }
            Console.ReadLine();
        }
    }
}
