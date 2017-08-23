using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Get_Sandwich_Messages;

namespace Get_Sandwich
{
    public class Utility
    {
        public string GetValidString()
        {
            var userInput = "";
            var validInput = false;
            Message.RequestUserInput();
            while (validInput == false)
            {
                userInput = Console.ReadLine();
                if (CheckIfTooShort(userInput))
                {
                    Message.TooShort();
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
            return userInput.Length < 11;
        }

        public int GetIndexOfFirstSlice(string userString)
        {
            return userString.IndexOf("bread");
        }

        public int GetIndexOfSecondSlice(string userString)
        {
            return userString.LastIndexOf("bread");
        }

        public string CreateNewString(string userString, int startOfSandwich, int endOfSandwich)
        {
            var newString = new StringBuilder();
            for (int i = startOfSandwich + 5; i < endOfSandwich; i++)
            {
                newString.Append(userString.Substring(i, 1));
            }
            return newString.ToString();
        }
    }
}
