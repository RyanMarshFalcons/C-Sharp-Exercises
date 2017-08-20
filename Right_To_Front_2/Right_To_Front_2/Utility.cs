using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Right_To_Front_2_Messages;

namespace Right_To_Front_2
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
            var last2Chars = userString.Substring(userString.Length - 2, 2);
            return last2Chars + userString.Substring(0, userString.Length - 2);
        }
    }
}
