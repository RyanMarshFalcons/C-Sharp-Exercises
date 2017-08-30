using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Index_N_Characters;
using Index_N_Characters_Messages;

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
            var maxNumChars = utility.GetMaxNumChars(userString, index);
            var numChars = utility.GetValidNumChars(maxNumChars);
            var newString = utility.CreateNewString(userString, index, numChars);
            Message.DisplayNewString(newString);
            Console.ReadLine();
        }
    }
}
