using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Non_Start_3_Messages;

namespace Non_Start_3
{
    public class Utility
    {
        public string GetValidString(int stringNum)
        {
            var userInput = "";
            var validInput = false;
            Message.RequestUserInput(stringNum);
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

        public string MakeNewString(List<string> userStrings)
        {
            var newString = "";
            foreach (var userString in userStrings)
            {
                newString += userString.Substring(1, userString.Length - 1);
            }
            if (newString.Length == 0)
            {
                return "an empty string";
            }
            else
            {
                return newString;
            }
        }
    }
}
