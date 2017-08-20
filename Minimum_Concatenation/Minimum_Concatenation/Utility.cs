using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minimum_Concatenation_Messages;

namespace Minimum_Concatenation
{
    public class Utility
    {
        public string GetValidString(string firstSecond)
        {
            var userInput = "";
            var validEntry = false;
            Message.RequestString(firstSecond);
            while (validEntry == false)
            {
                userInput = Console.ReadLine();
                if (!CheckIfLongEnough(userInput))
                {
                    Message.NotEnoughCharacters(firstSecond);
                }
                else
                {
                    validEntry = true;
                }
            }
            return userInput;
        }

        public bool CheckIfLongEnough(string input)
        {
            return input.Length >= 1;
        }

        public int GetMinimum(string userString1, string userString2)
        {
            return Math.Min(userString1.Length, userString2.Length);
        }

        public string CreateNewString(string userString1, string userString2, int minimum)
        {
            return userString1.Substring(0, minimum) + userString2.Substring(0, minimum);
        }
    }
}
