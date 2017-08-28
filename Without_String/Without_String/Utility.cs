using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Without_String_Messages;

namespace Without_String
{
    public class Utility
    {
        public string GetString(string baseRemove)
        {
            var userInput = "";
            Message.RequestUserInput(baseRemove);
            var validInput = false;
            while (validInput == false)
            {
                userInput = Console.ReadLine();
                if (IsTooShort(userInput))
                {
                    Message.NotLongEnough(baseRemove);
                }
                else
                {
                    validInput = true;
                }
            }
            return userInput;
        }

        public bool IsTooShort(string input)
        {
            return input.Length < 1;
        }

        public string RemoveInstancesFromBase(string baseString, string removeString)
        {
            var index = 0;
            while (index != -1)
            {
                index = baseString.IndexOf(removeString);
                if (index != -1)
                {
                    baseString = baseString.Substring(0, index) + (baseString.Substring(index + removeString.Length));
                }
            }
            return baseString;
        }
    }
}
