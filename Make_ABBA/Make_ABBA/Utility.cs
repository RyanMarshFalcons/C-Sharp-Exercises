using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Make_ABBA_Messages;

namespace Make_ABBA
{
    public class Utility
    {
        public string GetValidString()
        {
            var userInput = "";
            var validInput = false;
            Message.RequestUserInput();
            while (validInput == false)
            {
                userInput = Console.ReadLine();
                if (CheckIfTooShort(userInput))
                {
                    Message.MustBeAtLeast1Character();
                }
                else
                {
                    validInput = true;
                }
            }
            return userInput;
        }

        public bool CheckIfTooShort(string userInput)
        {
            return userInput.Length < 1;
        }

        public string MakeNewString(string userString1, string userString2)
        {
            var newString = new StringBuilder();
            newString.Append(userString1);
            newString.Append(userString2);
            newString.Append(userString2);
            newString.Append(userString1);
            return newString.ToString();
        }
    }
}
