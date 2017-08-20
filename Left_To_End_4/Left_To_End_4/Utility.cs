using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Left_To_End_4_Messages;

namespace Left_To_End_4
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
                    Message.AtLeastFiveCharacters();
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
            return input.Length >= 5;
        }

        public string CreateNewString(string userString)
        {
            var first2Chars = userString.Substring(0, 4);
            return userString.Substring(4, userString.Length - 4) + first2Chars;
        }
    }
}
