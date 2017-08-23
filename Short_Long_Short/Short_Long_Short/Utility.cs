using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Short_Long_Short_Messages;

namespace Short_Long_Short
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
            var newString = new StringBuilder();
            if (userString1.Length > userString2.Length)
            {
                newString.Append(userString2);
                newString.Append(userString1);
                newString.Append(userString2);
            }
            else
            {
                newString.Append(userString1);
                newString.Append(userString2);
                newString.Append(userString1);
            }
            return newString.ToString();
        }
    }
}
