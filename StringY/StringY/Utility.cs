using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringY_Messages;

namespace StringY
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

        public bool CheckIfStringY(string userString)
        {
            var yCount = userString.Count(c => c == 'y');
            var YCount = userString.Count(c => c == 'Y');
            return (yCount + YCount) >= 3;
        }

        public void DisplayResults(bool isStrinE)
        {
            if (isStrinE)
            {
                Message.IsStringY();
            }
            else
            {
                Message.IsntStringY();
            }
        }
    }
}
