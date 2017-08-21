using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beginning_Other_Messages;

namespace Beginning_Other
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
            if (firstString.Length > secondString.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckIfShorterIsBeginningOfLonger(string firstString, string secondString, bool firstIsLonger)
        {
            if (firstIsLonger)
            {
                return secondString == firstString.Substring(0, secondString.Length);
            }
            else
            {
                return firstString == secondString.Substring(0, firstString.Length);
            }
        }
    }
}
