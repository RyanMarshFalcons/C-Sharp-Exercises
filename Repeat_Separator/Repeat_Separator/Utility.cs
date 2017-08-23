using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repeat_Separator_Messages;

namespace Repeat_Separator
{
    public class Utility
    {
        public string GetValidString(string firstSecond)
        {
            var userInput = "";
            var validInput = false;
            Message.RequestUserInput(firstSecond);
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
            return userInput.Length < 1;
        }

        public int GetValidNumber()
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
                    if (CheckIfValidNumber(input) == false)
                    {
                        Message.NotValidNumber(input);
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

        public bool CheckIfValidNumber(string input)
        {
            return int.Parse(input) >= 2;
        }

        public string CreateNewString(string userString1, string userString2, int num)
        {
            var newString = new StringBuilder(userString1);
            for (int i = 0; i < num - 1; i++)
            {
                newString.Append(userString2 + userString1);
            }
            return newString.ToString();
        }
    }
}
