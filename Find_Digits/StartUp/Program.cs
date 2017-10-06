using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Find_Digits;
using Find_Digits_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userNum = utility.GetUserNumber();
            var divisibleDigits = utility.CalculateDivisibleDigits(userNum);
            utility.DisplayResults(userNum, divisibleDigits);
            Console.ReadLine();
        }
    }
}
