using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mix_String;
using Mix_String_Messages;

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
            var shorterLength = utility.GetShorterStringLength(firstString, secondString);
            var newString = utility.MixStringsTogether(firstString, secondString, shorterLength);
            Message.DisplayNewString(newString);
            Console.ReadLine();
        }
    }
}
