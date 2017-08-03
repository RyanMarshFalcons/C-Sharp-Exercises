using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Symbol_Count_Messages;

namespace Symbol_Count
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

        public int CountSymbolsInArray(char[] userInputArr)
        {
            return
                    (from c in userInputArr
                     where (Char.IsLetterOrDigit(c) == false) && (c != ' ')
                     select c).Count();
        }
    }
}
