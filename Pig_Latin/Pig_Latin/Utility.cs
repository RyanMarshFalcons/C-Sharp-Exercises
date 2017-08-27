using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pig_Latin_Messages;

namespace Pig_Latin
{
    public class Utility
    {
        public string GetValidEntry()
        {
            Message.EnterWord();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (input == "")
                {
                    Message.NoEmptyStrings();
                }
                else if (CheckIfHasSpaces(input) == true)
                {
                    Message.NoSpaces();
                }
                else if (CheckIfBeginsWithALetter(input) == false)
                {
                    Message.MustBeignWithALetter();
                }
                else
                {
                    isValidInput = true;
                }
            }
            return input;
        }

        public bool CheckIfHasSpaces(string input)
        {
            bool hasSpaces = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    hasSpaces = true;
                }
            }
            return hasSpaces;
        }

        public bool CheckIfBeginsWithALetter(string input)
        {
            return Char.IsLetter(input[0]);
        }

        public bool CheckIfBeginsWithVowel(string userString)
        {
            return CheckIfVowel(userString[0]);
        }

        public bool CheckIfVowel(char character)
        {
            return ((character == 'a') || (character == 'e') || (character == 'i') || (character == 'o') || (character == 'u') || (character == 'y') || (character == 'A') || (character == 'E') || (character == 'I') || (character == 'O') || (character == 'U') || (character == 'Y'));
        }

        public string AddYayToTheEnd(string userString)
        {
            return userString + "yay";
        }

        public string MoveConsonantsToTheEnd(string userString)
        {
            var numConsonants = ConsonantCounter(userString);
            return userString.Substring(numConsonants) + userString.Substring(0, numConsonants);
        }

        public int ConsonantCounter(string userString)
        {
            var counter = 0;
            for (int i = 0; i < userString.Length; i++)
            {
                if (CheckIfVowel(userString[i]) == true)
                {
                    break;
                }
                counter += 1;
            }
            return counter;
        }

        public string AddAyToTheEnd(string userString)
        {
            return userString + "ay";
        }
    }
}
