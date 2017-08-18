using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Long_Short_Long_Messages;

namespace Long_Short_Long
{
    public class Utility
    {
        public string GetValidString(string firstSecond)
        {
            var userInput = "";
            var validInput = false;
            Message.RequestUserInput(firstSecond);
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

        public bool CheckIfSameLength(string userString1, string userString2)
        {
            return userString1.Length == userString2.Length;
        }

        public string MakeNewString(string userString1, string userString2)
        {
            if (userString1.Length < userString2.Length)
            {
                return userString2 + userString1 + userString2;
            }
            else
            {
                return userString1 + userString2 + userString1;
            }
        }
    }
}
