using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Without_Y_Messages;

namespace Without_Y
{
    public class Utility
    {
        public string GetString()
        {
            var isValid = false;
            var userInput = "";
            Message.EnterString();
            while (isValid == false)
            {
                userInput = Console.ReadLine();
                if (!CheckIfValidString(userInput))
                {
                    Message.AtLeastOneCharacter();
                }
                else
                {
                    isValid = true;
                }
            }
            return userInput;
        }

        public bool CheckIfValidString(string input)
        {
            return input.Length >= 1;
        }

        public string CreateNewString(string userString)
        {
            while ((userString.IndexOf('y') == 0) || (userString.IndexOf('Y') == 0))
            {
                if (userString.Length == 1)
                {
                    return "an empty string";
                }
                else
                {
                    userString = userString.Substring(1, userString.Length - 1);
                }
            }
            while ((userString.LastIndexOf('y') == userString.Length - 1) || (userString.LastIndexOf('Y') == userString.Length - 1))
            {
                userString = userString.Substring(0, userString.Length - 1);
            }
            return userString;
        }
    }
}
