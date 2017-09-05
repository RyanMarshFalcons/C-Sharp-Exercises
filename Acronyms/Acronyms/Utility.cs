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
        public string GetUserString()
        {
            var userInput = "";
            Message.RequestUserInput();
            var validInput = false;
            while (validInput == false)
            {
                userInput = Console.ReadLine();
                if (IsTooShort(userInput))
                {
                    Message.NotLongEnough();
                }
                else
                {
                    if (ContainsAWord(userInput) == false)
                    {
                        Message.NoWords();
                    }
                    else
                    {
                        validInput = true;
                    }
                }
            }
            return userInput;
        }

        public bool IsTooShort(string input)
        {
            return input.Length < 2;
        }

        public bool ContainsAWord(string input)
        {
            var hasAWord = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i]))
                {
                    if (i == 0 || input[i - 1] == ' ')
                    {
                        hasAWord = true;
                    }
                }
            }
            return hasAWord;
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
    }
}
