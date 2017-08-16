using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Back_Around_Messages;

namespace Back_Around
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

        public string AddLastToFrontAndBack(string userString)
        {
            var last = userString.Substring(userString.Length - 1, 1);
            return last + userString + last;
        }
    }
}
