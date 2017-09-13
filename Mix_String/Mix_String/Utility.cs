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
        public string GetValidString()
        {
            var userInput = "";
            Message.RequestUserString();
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

        public bool AskToAddAnotherString()
        {
            var IsValidInput = false;
            var input = "";
            Message.AddAnotherString();
            while (IsValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfyOrn(input) == false)
                {
                    Message.NotyOrn();
                }
                else
                {
                    IsValidInput = true;
                }
            }
            return input == "y";
        }

        public bool CheckIfyOrn(string input)
        {
            return input == "y" || input == "n";
        }

        public int GetShortestStringLength(List<string> userStrings)
        {
            var shortestLength = userStrings[0].Length;
            for (int i = 0; i < userStrings.Count; i++)
            {
                if (userStrings[i].Length < shortestLength)
                {
                    shortestLength = userStrings[i].Length;
                }
            }
            return shortestLength;
        }

        public string MixStringsTogether(List<string> userStrings, int shortestLength)
        {
            var newString = new StringBuilder();
            for (int i = 0; i < shortestLength; i++)
            {
                for (int j = 0; j < userStrings.Count; j++)
                {
                    newString.Append(userStrings[j].Substring(i, 1));
                }
            }
            return newString.ToString();
        }
    }
}
