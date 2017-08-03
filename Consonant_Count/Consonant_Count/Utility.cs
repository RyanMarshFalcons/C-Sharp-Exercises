using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consonant_Count_Messages;

namespace Consonant_Count
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

        public int CountConsonantsInArray(char[] userInputArr)
        {
            return
                    (from c in userInputArr
                     where ((Char.IsLetter(c)) && ((c != 'a') && (c != 'A') && (c != 'e') && (c != 'E') && (c != 'i') && (c != 'I') && (c != 'o') && (c != 'O') && (c != 'u') && (c != 'U') && (c != 'y') && (c != 'Y')))
                     select c).Count();
        }
    }
}
