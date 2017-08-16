using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Middle_Around_Messages;

namespace Middle_Around
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
                    Message.AtLeastThreeCharacters();
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

        public string AddMiddleToFrontAndBack(string userString)
        {
            var middle = "";
            if (userString.Length % 2 != 0)
            {
                middle = userString.Substring((userString.Length + 1) / 2 - 1, 1);
            }
            else
            {
                middle = userString.Substring(userString.Length / 2 - 1, 2);
            }
            return middle + userString + middle;
        }
    }
}
