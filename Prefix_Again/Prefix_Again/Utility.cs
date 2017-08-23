using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prefix_Again_Messages;

namespace Prefix_Again
{
    public class Utility
    {
        public string GetValidString()
        {
            var userInput = "";
            var validInput = false;
            Message.RequestUserInput();
            while (validInput == false)
            {
                userInput = Console.ReadLine();
                if (CheckIfTooShort(userInput))
                {
                    Message.TooShort();
                }
                else
                {
                    validInput = true;
                }
            }
            return userInput;
        }

        public bool CheckIfTooShort(string userInput)
        {
            return userInput.Length < 2;
        }

        public int GetValidNumber(int maxNumChars)
        {
            Message.EnterNumber();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotANumber(input);
                }
                else
                {
                    if (CheckIfValidNumber(input, maxNumChars) == false)
                    {
                        Message.NotValidNumber(input, maxNumChars);
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return int.Parse(input);
        }

        public bool CheckIfInt(string input)
        {
            var num = 0;
            return int.TryParse(input, out num);
        }

        public bool CheckIfValidNumber(string input, int maxNumChars)
        {
            return ((int.Parse(input) <= maxNumChars) && (int.Parse(input) >= 1));
        }

        public string GetPrefix(string userString, int num)
        {
            return userString.Substring(0, num);
        }

        public bool CheckForMatch(string userString, string prefix, int num)
        {
            var doesRepeat = false;
            for (int i = num; i < userString.Length - num + 1; i++)
            {
                if (userString.Substring(i, num) == prefix)
                {
                    doesRepeat = true;
                }
            }
            return doesRepeat;
        }
    }
}
