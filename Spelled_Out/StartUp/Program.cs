using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spelled_Out;
using Spelled_Out_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userNum = utility.GetValidNumber();
            var userNumAsArray = utility.ConvertNumToIntArray(userNum);
            var userNumSpelledOut = utility.SpellOutNumber(userNumAsArray);
            Message.DisplayResults(userNum, userNumSpelledOut);
            Console.ReadLine();
        }
    }
}
