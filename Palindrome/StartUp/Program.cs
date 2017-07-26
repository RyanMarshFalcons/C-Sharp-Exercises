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
            var manipulation = new Manipulation();
            var input = manipulation.GetUserInput();
            var reversedInput = manipulation.InputInReverse(input);
            var adjustedInput = manipulation.AdjustString(input);
            var adjustedReverse = manipulation.AdjustString(reversedInput);
            var isPalindrome = manipulation.FindOutIfPalindrome(adjustedInput, adjustedReverse);
            manipulation.DisplayResults(input, isPalindrome);
            Console.ReadLine();
        }
    }
}
