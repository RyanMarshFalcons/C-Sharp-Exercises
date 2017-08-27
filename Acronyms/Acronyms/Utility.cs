using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acronyms_Messages;

namespace Acronyms
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
            return input.Length < 2;
        }

        public string ConvertToAcronym(string userInput)
        {
            var acronym = new StringBuilder();
            if (Char.IsLetter(userInput[0]))
            {
                acronym.Append(userInput[0]);
            }
            for (int i = 1; i < userInput.Length; i++)
            {
                if (userInput[i -1] == ' ' && Char.IsLetter(userInput[i]))
                {
                    acronym.Append(userInput[i]);
                }
            }
            return acronym.ToString().ToUpper();
        }

        public void DisplayResults(string userInput, string acronym)
        {
            if (acronym.Length == 0)
            {
                Message.NoLetters();
            }
            else
            {
                Message.DisplayResult(userInput, acronym);
            }
        }
    }
}
