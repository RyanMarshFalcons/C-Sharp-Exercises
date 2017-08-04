using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concatenate_Strings_Messages;

namespace Concatenate_Strings
{
    public class Utility
    {
        public string GetUserInput(string firstOrSecond)
        {
            var userInput = "";
            Message.RequestString(firstOrSecond);
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

        public string ConcatenateStrings(string firstInput, string secondInput)
        {
            return firstInput + secondInput;
        }
    }
}
