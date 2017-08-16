using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Every_Fourth_Messages;

namespace Every_Fourth
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

        public string FormStringFromEveryFourthChar(string userString)
        {
            var newString = userString.Substring(0, 1);
            for (int i = 4; i < userString.Length; i += 4)
            {
                newString += userString.Substring(i, 1);
            }
            return newString;
        }
    }
}
