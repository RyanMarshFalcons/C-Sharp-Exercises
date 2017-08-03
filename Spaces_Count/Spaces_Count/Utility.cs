using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spaces_Count_Messages;

namespace Spaces_Count
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

        public char[] ConvertToCharArray(string userInput)
        {
            return userInput.ToCharArray();
        }

        public int CountSpacesInArray(char[] userInputArr)
        {
            return
                    (from c in userInputArr
                     where c == ' '
                     select c).Count();
        }
    }
}
