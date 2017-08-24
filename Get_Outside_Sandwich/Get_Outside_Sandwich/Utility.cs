using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Get_Outside_Sandwich_Messages;

namespace Get_Outside_Sandwich
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
            if ((startOfSandwich == 0) && (endOfSandwich == userString.Length - 5))
            {
                return "an empty string";
            }
            var newString = new StringBuilder();
            if (startOfSandwich != 0)
            {
                for (int i = 0; i < startOfSandwich; i++)
                {
                    newString.Append(userString.Substring(i, 1));
                }
            }
            if (endOfSandwich != userString.Length - 5)
            {
                newString.Append(userString.Substring(endOfSandwich + 5));
            }
            return newString.ToString();
        }
    }
}
