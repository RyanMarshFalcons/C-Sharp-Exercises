using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extra_Middle_Messages;

namespace Extra_Middle
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
                    Message.MustBeAtLeast2Characters();
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

        public bool CheckIfEvenLength(string userString)
        {
            return userString.Length % 2 == 0;
        }

        public string MakeNewString(string userString, bool isEven)
        {
            if (isEven)
            {
                var middleTwoChars = userString.Substring(userString.Length / 2 - 1, 2);
                return middleTwoChars + middleTwoChars + middleTwoChars;
            }
            else
            {
                var middleThreeChars = userString.Substring((userString.Length - 1) / 2 - 1, 3);
                return middleThreeChars + middleThreeChars;
            }
        }
    }
}
