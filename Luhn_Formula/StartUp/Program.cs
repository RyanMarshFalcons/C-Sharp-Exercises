using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Luhn_Formula;
using Luhn_Formula_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userNumAsString = utility.GetUserNumberAsString();
            var userNumWithoutSpaces = utility.RemoveSpaces(userNumAsString);
            var stringLengthIsEven = utility.StringLengthIsEven(userNumWithoutSpaces);
            var modifiedUserNum = utility.DoubleEverySecondDigitFromRight(userNumWithoutSpaces, stringLengthIsEven);
            var sum = utility.GetSumOfDigits(modifiedUserNum);
            utility.DisplayResults(sum);
            Console.ReadLine();
        }
    }
}
