using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mix_String_Messages;

namespace Mix_String
{
    public class Utility
    {
        public string GetValidString(string firstSecond)
        {
            var userInput = "";
            Message.RequestUserInput(firstSecond);
            var validEntry = false;
            while (validEntry == false)
            {
                userInput = Console.ReadLine();
                if (CheckIfLongEnough(userInput) == false)
                {
                    Message.NotEnoughCharacters();
                }
                else
                {
                    validEntry = true;
                }
            }
            return userInput;
        }

        public bool CheckIfLongEnough(string userInput)
        {
            return userInput.Length >= 1;
        }

        public int GetShorterStringLength(string userString1, string userString2)
        {
            return Math.Min(userString1.Length, userString2.Length);
        }

        public string MixStringsTogether(string userString1, string userString2, int shorterLength)
        {
            var newString = new StringBuilder();
            for (int i = 0; i < shorterLength; i++)
            {
                newString.Append(userString1.Substring(i, 1));
                newString.Append(userString2.Substring(i, 1));
            }
            if (userString1.Length > shorterLength)
            {
                newString.Append(userString1.Substring(userString1.Length - (userString1.Length - shorterLength)));
            }
            if (userString2.Length > shorterLength)
            {
                newString.Append(userString2.Substring(userString2.Length - (userString2.Length - shorterLength)));
            }
            return newString.ToString();
        }
    }
}
