using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwapUpperLowerCases_Messages;

namespace SwapUpperLowerCases
{
    public class Utility
    {
        public string GetUserInput()
        {
            var userInput = "";
            Message.RequestUserInput();
            var validInput = false;
            while (validInput == false)
            {
                userInput = Console.ReadLine();
                if (IsToShort(userInput))
                {
                    Message.NotLongEnough();
                }
                else
                {
                    validInput = true;
                }
            }
            return userInput;
        }

        public bool IsToShort(string input)
        {
            return input.Length < 1;
        }

        public string SwapCases(string userInput)
        {
            var newString = new StringBuilder();
            for (int i = 0; i < userInput.Length; i++)
            {
                if (Char.IsLower(userInput[i]))
                {
                    newString.Append(Char.ToUpper(userInput[i]));
                }
                else
                {
                    newString.Append(Char.ToLower(userInput[i]));
                }
            }
            return newString.ToString(); 
        }
    }
}
