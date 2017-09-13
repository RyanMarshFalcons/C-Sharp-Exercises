using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Substring_Count_Messages;

namespace Substring_Count
{
    public class Utility
    {
        public string GetValidString(string stringSubstring)
        {
            var userInput = "";
            Message.RequestUserInput(stringSubstring);
            var validEntry = false;
            while (validEntry == false)
            {
                userInput = Console.ReadLine();
                if (CheckIfLongEnough(userInput) == false)
                {
                    Message.NotEnoughCharacters(stringSubstring);
                }
                else
                {
                    validEntry = true;
                }
            }
            return userInput;
        }

        public bool CheckIfLongEnough(string userInput)
        {
            return userInput.Length >= 1;
        }

        public bool CheckIfSubstringIsLonger(string userString, string userSubstring)
        {
            return userSubstring.Length > userString.Length;
        }

        public int GetCount(string userString, string userSubstring, bool substringIsLonger)
        {
            if (substringIsLonger)
            {
                return 0;
            }
            else
            {
                var count = 0;
                for (int i = 0; i < userString.Length - (userSubstring.Length - 1); i++)
                {
                    if (userString.Substring(i, userSubstring.Length) == userSubstring)
                    {
                        count += 1;
                    }
                }
                return count;
            }
        }
    }
}
