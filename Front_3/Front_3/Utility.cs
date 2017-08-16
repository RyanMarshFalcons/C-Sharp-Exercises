using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Front_3_Messages;

namespace Front_3
{
    public class Utility
    {
        public string GetString ()
        {
            var isValid = false;
            var userInput = "";
            Message.EnterString();
            while (isValid == false)
            {
                userInput = Console.ReadLine();
                if (!CheckIfValidString(userInput))
                {
                    Message.AtLeastThree();
                }
                else
                {
                    isValid = true;
                }
            }
            return userInput;
        }

        public bool CheckIfValidString (string input)
        {
            return input.Length >= 3;
        }

        public string CreateNewString (string userString)
        {
            var first3Chars = userString.Substring(0, 3);
            return first3Chars + first3Chars + first3Chars;
        }
    }
}
