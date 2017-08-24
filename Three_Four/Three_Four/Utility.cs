using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Three_Four_Messages;

namespace Three_Four
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
            return userInput.Length < 7;
        }

        public string CreateNewString(string userString)
        {
            var newString = new StringBuilder();
            for (int i = 0; i < userString.Length - 6; i += 7)
            {
                newString.Append(userString.Substring(i + 3, 4));
                newString.Append(userString.Substring(i, 3));
            }
            return newString.ToString();
        }
    }
}
