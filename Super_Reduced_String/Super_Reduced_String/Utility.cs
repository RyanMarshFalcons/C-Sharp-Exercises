using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Super_Reduced_String_Messages;

namespace Super_Reduced_String
{
    public class Utility
    {
        public string GetUserString()
        {
            var userInput = "";
            var validEntry = false;
            Message.EnterUserString();
            while (!validEntry)
            {
                userInput = Console.ReadLine();
                if (!CheckIfLongEnough(userInput))
                {
                    Message.UserStringNotLongEnough();
                }
                else
                {
                    validEntry = true;
                }
            }
            return userInput;
        }

        public bool CheckIfLongEnough(string input)
        {
            return input.Length >= 2;
        }

        public ReducedString ReduceUserString(string userString)
        {
            var foundMatch = true;
            var timesReduced = 0;
            while (foundMatch)
            {
                foundMatch = false;
                for (int i = userString.Length - 1; i > 0; i--)
                {
                    if (userString[i] == userString[i - 1])
                    {
                        timesReduced++;
                        userString = userString.Remove(i - 1, 2);
                        foundMatch = true;
                        break;
                    }
                }
            }
            return new ReducedString() { RemainingCharacters = userString, TimesReduced = timesReduced };
        }

        public void DisplayResults(ReducedString reducedString)
        {
            if (reducedString.TimesReduced == 0)
            {
                Message.StringUnableToBeReduced();
            }
            else if (reducedString.RemainingCharacters == "")
            {
                Message.StringReducedToNothing(reducedString.TimesReduced);
            }
            else
            {
                Message.DisplaySuperReducedString(reducedString.RemainingCharacters, reducedString.TimesReduced);
            }
        }
    }
}
