using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Front_4_Messages;

namespace Front_4
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
                    Message.AtLeastFour();
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
            var first4Chars = userString.Substring(0, 4);
            return first4Chars + first4Chars + first4Chars + first4Chars;
        }
    }
}
