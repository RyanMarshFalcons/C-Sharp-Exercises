using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Palindrome;
using Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var input = utility.GetUserInput();
            var reversedInput = utility.InputInReverse(input);
            var adjustedInput = utility.AdjustString(input);
            var adjustedReverse = utility.AdjustString(reversedInput);
            var isPalindrome = utility.FindOutIfPalindrome(adjustedInput, adjustedReverse);
            utility.DisplayResults(input, isPalindrome);
            Console.ReadLine();
        }
    }
}
