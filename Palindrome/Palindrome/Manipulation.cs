using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messages;

namespace Palindrome
{
    public class Manipulation
    {
        public string GetUserInput()
        {
            var userInput = "";
            Message.RequestUserInput();
            while (userInput == "")
            {
                userInput = Console.ReadLine();
                if (userInput == "")
                {
                    Message.NoEmptyStrings();
                }
            }
            return userInput;
        }

        public string InputInReverse(string userInput)
        {
            var userInputAsArray = userInput.ToCharArray();
            Array.Reverse(userInputAsArray);
            return new string(userInputAsArray);
        }

        public string AdjustString(string original)
        {
            var adjusted = original.Replace(" ", "");
            adjusted = adjusted.Replace(",", "");
            adjusted = adjusted.Replace(".", "");
            adjusted = adjusted.Replace("'", "");
            adjusted = adjusted.Replace("\"", "");
            adjusted = adjusted.Replace(":", "");
            adjusted = adjusted.Replace(";", "");
            adjusted = adjusted.Replace("!", "");
            adjusted = adjusted.Replace("?", "");
            return adjusted.ToLower();
        }

        public bool FindOutIfPalindrome(string input, string reversedInput)
        {
            return input == reversedInput;
        }

        public void DisplayResults(string input, bool isPalindrome)
        {
            if (isPalindrome)
            {
                Message.IsAPalindrome(input);
            }
            else
            {
                Message.IsNotAPalindrome(input);
            }
        }
    }
}
