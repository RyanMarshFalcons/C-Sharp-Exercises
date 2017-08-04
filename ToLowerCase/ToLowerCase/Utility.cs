using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToLowerCase_Messages;

namespace ToLowerCase
{
    public class Utility
    {
        public string GetUserInput()
        {
            var userInput = "";
            Message.RequestUserInput();
            while (userInput == "")
            {
                userInput = Console.ReadLine();
                if (userInput == "")
                {
                    Message.NoEmptyStrings();
                }
            }
            return userInput;
        }

        public string ToLowerCase(string userInput)
        {
            return userInput.ToLower();
        }
    }
}
