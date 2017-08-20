using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Left_To_End_2_Messages;

namespace Left_To_End_2
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
                    Message.AtLeastThreeCharacters();
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
            return input.Length >= 3;
        }

        public string CreateNewString(string userString)
        {
            var first2Chars = userString.Substring(0, 2);
            return userString.Substring(2, userString.Length - 2) + first2Chars;
        }
    }
}
