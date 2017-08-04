using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToUpperCase_Messages;

namespace ToUpperCase
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

        public string ToUpperCase(string userInput)
        {
            return userInput.ToUpper();
        }
    }
}
