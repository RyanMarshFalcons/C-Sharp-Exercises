using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Every_Nth_Character;
using Every_Nth_Character_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetValidString();
            var num = utility.GetValidNumber(userString);
            var newString = utility.FormStringFromEveryNthChar(userString, num);
            Message.DisplayNewString(newString, num);
            Console.ReadLine();
        }
    }
}
