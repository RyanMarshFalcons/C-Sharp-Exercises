using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Long_Short_Long;
using Long_Short_Long_Messages;

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
            while (userString1.Length == userString2.Length)
            {
                Message.CannotBeSameLength();
                userString2 = utility.GetValidString("second");
            }
            var newString = utility.MakeNewString(userString1, userString2);
            Message.DisplayResults(newString);
            Console.ReadLine();
        }
    }
}
