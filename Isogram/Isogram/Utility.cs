using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Isogram_Messages;

namespace Isogram
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
                    if (ContainsNoLetters(input))
                    {
                        Message.NoLetters();
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return input;
        }

        public bool IsTooShort(string input)
        {
            return input.Length < 1;
        }

        public bool ContainsNoLetters(string input)
        {
            return !input.Any(x => char.IsLetter(x));
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

        public bool IsIsogram(string userString, string userStringUniqueChars)
        {
            return userString == userStringUniqueChars;
        }

        public void DisplayResults(bool isIsogram)
        {
            if (isIsogram)
            {
                Message.IsAnIsogram();
            }
            else
            {
                Message.IsNotAnIsogram();
            }
        }
    }
}
