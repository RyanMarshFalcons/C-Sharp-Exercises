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
            var inputAsArray = ConvertToCharArray(input);
            bool hasSpaces = false;
            foreach (var character in inputAsArray)
            {
                if (character == ' ')
                {
                    hasSpaces = true;
                }
            }
            return hasSpaces;
        }

        public bool CheckIfBeginsWithALetter(string input)
        {
            var inputAsArray = ConvertToCharArray(input);
            return Char.IsLetter(inputAsArray[0]);
        }

        public char[] ConvertToCharArray(string word)
        {
            return word.ToCharArray();
        }

        public bool CheckIfBeginsWithVowel(char[] wordAsArray)
        {
            return CheckIfVowel(wordAsArray[0]);
        }

        public bool CheckIfVowel(char character)
        {
            return ((character == 'a') || (character == 'e') || (character == 'i') || (character == 'o') || (character == 'u') || (character == 'y') || (character == 'A') || (character == 'E') || (character == 'I') || (character == 'O') || (character == 'U') || (character == 'Y'));
        }

        public string AddYayToTheEnd(char[] wordAsArray)
        {
            return new string(wordAsArray) + "yay";
        }

        public string MoveConsonantsToTheEnd(char[] wordAsArray)
        {
            var placeHolderChar = ' ';
            var newStringEnding = "";
            var numConsonants = ConsonantCounter(wordAsArray);
            for (int i = 0; i < numConsonants; i++)
            {
                placeHolderChar = wordAsArray[i];
                newStringEnding += (placeHolderChar.ToString()).ToLower();
                wordAsArray[i] = ' ';
            }
            var newString = new string(wordAsArray);
            newString = newString.Replace(" ", "");
            return newString + newStringEnding;
        }

        public int ConsonantCounter(char[] wordAsArray)
        {
            var counter = 0;
            foreach (var character in wordAsArray)
            {
                if (CheckIfVowel(character) == true)
                {
                    break;
                }
                counter += 1;
            }
            return counter;
        }

        public string AddAyToTheEnd(string input)
        {
            return input + "ay";
        }
    }
}
