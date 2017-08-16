using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringE_Messages;

namespace StringE
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

        public bool CheckIfStringE(string userString)
        {
            var eCount = userString.Count(c => c == 'e');
            var ECount = userString.Count(c => c == 'E');
            return (eCount + ECount) >= 3;
        }

        public void DisplayResults(bool isStrinE)
        {
            if (isStrinE)
            {
                Message.IsStringE();
            }
            else
            {
                Message.IsntStringE();
            }
        }
    }
}
