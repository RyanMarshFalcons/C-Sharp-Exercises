using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Letter_Count_Messages;

namespace Letter_Count
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

        public int CountLettersInArray(char[] userInputArr)
        {
            return
                    (from c in userInputArr
                     where Char.IsLetter(c)
                     select c).Count();
        }
    }
}
