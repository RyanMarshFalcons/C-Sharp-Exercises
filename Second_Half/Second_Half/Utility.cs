using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Second_Half_Messages;

namespace Second_Half
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

        public bool CheckIfEvenLength(string userString)
        {
            return userString.Length % 2 == 0;
        }

        public string MakeNewString(string userString, bool isEven)
        {
            if (!isEven)
            {
                userString = " " + userString;
            }
            return userString.Substring(userString.Length / 2);
        }
    }
}
