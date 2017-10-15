using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Separate_The_Numbers;
using Seperate_The_Numbers_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userNumAsString = utility.GetUserNum();
            var withoutLeadingZeroes = utility.RemoveLeadingZeroes(userNumAsString);
            var firstTwoNumbers = utility.GetFirstTwoNumbers(withoutLeadingZeroes);
            if (firstTwoNumbers[0] == -1)
            {
                Message.UnableToSeparateTheNumbers(userNumAsString);
            }
            else
            {
                var remainderOfUserNum = utility.RemoveFirstTwoNumbersFromString(userNumAsString, firstTwoNumbers);
                var separatedNumbers = utility.GetRestOfNumbers(remainderOfUserNum, firstTwoNumbers);
                utility.DisplayResults(separatedNumbers, userNumAsString);
            }
            Console.ReadLine();
        }
    }
}
