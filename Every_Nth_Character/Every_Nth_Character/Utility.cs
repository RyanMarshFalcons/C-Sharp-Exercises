using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Every_Nth_Character_Messages;

namespace Every_Nth_Character
{
    public class Utility
    {
        public string GetValidString()
        {
            var userInput = "";
            var validEntry = false;
            Message.RequestUserString();
            while (!validEntry)
            {
                userInput = Console.ReadLine();
                if (CheckIfTooShort(userInput))
                {
                    Message.TooShort();
                }
                else
                {
                    validEntry = true;
                }
            }
            return userInput;
        }

        public bool CheckIfTooShort(string input)
        {
            return input.Length < 3;
        }

        public int GetValidNumber(string userString)
        {
            Message.InputNumber();
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
                    if (CheckIfOutOfRange(input, userString))
                    {
                        Message.OutOfRange(input, userString.Length -1);
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

        public bool CheckIfOutOfRange(string input, string userString)
        {
            return int.Parse(input) < 2 || int.Parse(input) > userString.Length - 1;
        }

        public string FormStringFromEveryNthChar(string userString, int num)
        {
            var newString = new StringBuilder();
            newString.Append(userString.Substring(0, 1));
            for (int i = num; i < userString.Length; i += num)
            {
                newString.Append(userString.Substring(i, 1));
            }
            return newString.ToString();
        }
    }
}
