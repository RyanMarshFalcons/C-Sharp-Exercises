using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Two_Three_Messages;

namespace Two_Three
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
            return userInput.Length < 5;
        }

        public string CreateNewString(string userString)
        {
            var newString = new StringBuilder();
            for (int i = 0; i < userString.Length - 4; i += 5)
            {
                newString.Append(userString.Substring(i + 2, 3));
                newString.Append(userString.Substring(i, 2));
            }
            return newString.ToString();
        }
    }
}
