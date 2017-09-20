using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pangram_Messages;

namespace Pangram
{
    public class Utility
    {
        public string GetUserString()
        {
            Message.EnterString();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (IsTooShort(input))
                {
                    Message.NotLongEnough();
                }
                else
                {
                    isValidInput = true;
                }
            }
            return input;
        }

        public bool IsTooShort(string input)
        {
            return input.Length < 1;
        }

        public string RemoveNonLetters(string userString)
        {
            return string.Concat(userString.Where(c => char.IsLetter(c)));
        }

        public string CapitalizeAllLetters(string userString)
        {
            return userString.ToUpper();
        }

        public string RemoveDuplicates(string userString)
        {
            return new string(userString.ToCharArray().Distinct().ToArray());
        }

        public bool IsPangram(string userString)
        {
            return userString.Length == 26;
        }

        public void DisplayResults(bool isPangram)
        {
            if (isPangram)
            {
                Message.IsAPangram();
            }
            else
            {
                Message.IsNotAPangram();
            }
        }
    }

}
