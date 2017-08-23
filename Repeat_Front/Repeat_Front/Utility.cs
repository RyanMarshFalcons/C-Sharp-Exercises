using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repeat_Front_Messages;

namespace Repeat_Front
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
                    Message.MustBeAtLeast1Character();
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

        public int GetValidNumber(int numChars)
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
                    if (CheckIfValidNumber(input, numChars) == false)
                    {
                        Message.NotValidNumber(input, numChars);
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

        public bool CheckIfValidNumber(string input, int numChars)
        {
            return ((int.Parse(input) <= numChars) && (int.Parse(input) >= 1));
        }

        public string CreateNewString(string userString, int num)
        {
            var newString = new StringBuilder();
            for (int i = 0; i < num; i++)
            {
                newString.Append(userString.Substring(0, num));
            }
            return newString.ToString();
        }
    }
}
