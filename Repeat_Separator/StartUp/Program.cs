using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repeat_Separator;
using Repeat_Separator_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var firstString = utility.GetValidString("first");
            var secondString = utility.GetValidString("second");
            var num = utility.GetValidNumber();
            var newString = utility.CreateNewString(firstString, secondString, num);
            Message.DisplayResults(newString);
            Console.ReadLine();
        }
    }
}
