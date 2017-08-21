using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quadruple_Characters_Messages;

namespace Quadruple_Characters
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
                    Message.NotEnoughCharacters();
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
            return input.Length >= 1;
        }

        public string CreateNewString(string userString)
        {
            var newString = "";
            for (int i = 0; i < userString.Length; i++)
            {
                newString += (userString.Substring(i, 1) + userString.Substring(i, 1) + userString.Substring(i, 1) + userString.Substring(i, 1));
            }
            return newString;
        }
    }
}
