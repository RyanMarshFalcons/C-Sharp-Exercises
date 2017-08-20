using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Index_Three_Chars;
using Index_Three_Chars_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetString();
            var maxIndex = utility.GetMaxIndex(userString);
            var index = utility.GetValidIndex(maxIndex);
            var newString = utility.CreateNewString(userString, index);
            Message.DisplayNewString(newString);
            Console.ReadLine();
        }
    }
}
