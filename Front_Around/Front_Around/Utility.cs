using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Front_Around_Messages;

namespace Front_Around
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

        public string AddFirstToFrontAndBack(string userString)
        {
            var first = userString.Substring(0, 1);
            return first + userString + first;
        }
    }
}
