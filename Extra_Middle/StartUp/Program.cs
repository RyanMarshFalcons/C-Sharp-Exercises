using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extra_Middle;
using Extra_Middle_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetValidString();
            var isEven = utility.CheckIfEvenLength(userString);
            var newString = utility.MakeNewString(userString, isEven);
            Message.DisplayResults(newString);
            Console.ReadLine();
        }
    }
}
