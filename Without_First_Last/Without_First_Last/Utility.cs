using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Without_First_Last_Messages;

namespace Without_First_Last
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
                    Message.MustBeAtLeast2Characters();
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
            return userInput.Length < 2;
        }

        public string MakeNewString(string userString)
        {
            if (userString.Length == 2)
            {
                return "an empty string";
            }
            else
            {
                return userString.Substring(1, userString.Length - 2);
            }
        }
    }
}
