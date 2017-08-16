using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Begin_Up_Messages;

namespace Begin_Up
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

        public string MakeBeginningUpperCase(string userString)
        {
            var begin = (userString.Substring(0, 3)).ToUpper();
            var rest = userString.Substring(3, userString.Length - 3);
            return begin + rest;
        }
    }
}
