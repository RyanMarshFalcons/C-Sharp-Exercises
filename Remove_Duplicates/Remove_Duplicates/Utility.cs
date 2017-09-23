using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Remove_Duplicates_Messages;
using System.Text.RegularExpressions;

namespace Remove_Duplicates
{
    public enum RemoveDuplicate { letters, numbers, symbols };
    public class Utility
    {
        public string GetUserString()
        {
            var userInput = "";
            Message.RequestUserString();
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

        public string GetValidSelection()
        {
            Message.RequestSelection();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfValidSelection(input) == false)
                {
                    Message.InvalidSelection(input);
                }
                else
                {
                    isValidInput = true;
                }
            }
            return input;
        }

        public bool CheckIfValidSelection(string input)
        {
            return Regex.IsMatch(input, "[A-C]") && input.Length == 1;
        }

        public RemoveDuplicate ConvertLetterToRemoveDupicate(string selectionLetter)
        {
            switch (selectionLetter)
            {
                case "A":
                    return RemoveDuplicate.letters;
                    break;
                case "B":
                    return RemoveDuplicate.numbers;
                    break;
                case "C":
                default:
                    return RemoveDuplicate.symbols;
                    break;
            }
        }

        public string RemoveDuplicateLetters(string userString)
        {
            var newString = "";
            List<char> uniqueLetters = new List<char>();
            foreach (char character in userString)
            {
                if (Char.IsLetter(character))
                {
                    if (uniqueLetters.Contains(character))
                        continue;
                }
                    newString += character.ToString();
                    uniqueLetters.Add(character);
            }
            return newString;
        }

        public string RemoveDuplicateNumbers(string userString)
        {
            var newString = "";
            List<char> uniqueNumbers = new List<char>();
            foreach (char character in userString)
            {
                if (Char.IsNumber(character))
                {
                    if (uniqueNumbers.Contains(character))
                        continue;
                }
                newString += character.ToString();
                uniqueNumbers.Add(character);
            }
            return newString;
        }

        public string RemoveDuplicateSymbols(string userString)
        {
            var newString = "";
            List<char> uniqueSymbols = new List<char>();
            foreach (char character in userString)
            {
                if (!Char.IsLetter(character) && !Char.IsNumber(character) && character != ' ')
                {
                    if (uniqueSymbols.Contains(character))
                        continue;
                }
                newString += character.ToString();
                uniqueSymbols.Add(character);
            }
            return newString;
        }
    }
}
