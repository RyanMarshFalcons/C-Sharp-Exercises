using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Front_And_Back_Messages;

namespace Front_And_Back
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
                    Message.AtLeastTwoCharacters();
                }
                else
                {
                    validEntry = true;
                }
            }
            return userInput;
        }

        public bool CheckIfTooShort (string input)
        {
            return input.Length < 2;
        }

        public string SwapFirstAndLast(string userString)
        {
            var first = userString.Substring(0, 1);
            var last = userString.Substring(userString.Length - 1, 1);
            var middle = "";
            if (userString.Length > 2)
            {
                middle = userString.Substring(1, userString.Length - 2);
            }
            return last + middle + first;
        }
    }
}
