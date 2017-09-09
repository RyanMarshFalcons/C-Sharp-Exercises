using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using End_Other_Messages;

namespace End_Other
{
    public class Utility
    {
        public string GetValidString(string firstSecond)
        {
            var userInput = "";
            Message.RequestUserInput(firstSecond);
            var validEntry = false;
            while (validEntry == false)
            {
                userInput = Console.ReadLine();
                if (CheckIfLongEnough(userInput) == false)
                {
                    Message.NotEnoughCharacters();
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

        public bool CheckIfSameLength(string firstString, string secondString)
        {
            return firstString.Length == secondString.Length;
        }

        public bool CheckIfSameString(string firstString, string secondString)
        {
            return firstString == secondString;
        }

        public bool CheckIfFirstIsLonger(string firstString, string secondString)
        {
            return firstString.Length > secondString.Length;
        }

        public bool CheckIfShorterIsEndOfLonger(string firstString, string secondString, bool firstIsLonger)
        {
            if (firstIsLonger)
            {
                return secondString == firstString.Substring(firstString.Length - secondString.Length);
            }
            else
            {
                return firstString == secondString.Substring(secondString.Length - firstString.Length);
            }
        }
    }
}
