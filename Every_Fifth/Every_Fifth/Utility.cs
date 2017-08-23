using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Every_Fifth_Messages;

namespace Every_Fifth
{
    public class Utility
    {
        public string GetString()
        {
            var userInput = "";
            var validEntry = false;
            Message.RequestUserInput();
            while (!validEntry)
            {
                userInput = Console.ReadLine();
                if (CheckIfTooShort(userInput))
                {
                    Message.AtLeastOneCharacter();
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
            return input.Length < 1;
        }

        public string FormStringFromEveryFifthChar(string userString)
        {
            var newString = new StringBuilder();
            newString.Append(userString.Substring(0, 1));
            for (int i = 5; i < userString.Length; i += 5)
            {
                newString.Append(userString.Substring(i, 1));
            }
            return newString.ToString();
        }
    }
}
