using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Left_To_End_3_Messages;

namespace Left_To_End_3
{
    public class Utility
    {
        public string GetString()
        {
            var isValid = false;
            var userInput = "";
            Message.EnterString();
            while (isValid == false)
            {
                userInput = Console.ReadLine();
                if (!CheckIfValidString(userInput))
                {
                    Message.AtLeastFourCharacters();
                }
                else
                {
                    isValid = true;
                }
            }
            return userInput;
        }

        public bool CheckIfValidString(string input)
        {
            return input.Length >= 4;
        }

        public string CreateNewString(string userString)
        {
            var first3Chars = userString.Substring(0, 3);
            return userString.Substring(3, userString.Length - 3) + first3Chars;
        }
    }
}
