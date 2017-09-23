using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pig_Latin_Messages;
using System.Text.RegularExpressions;

namespace Pig_Latin
{
    public class Utility
    {
        public string GetUserString()
        {
            Message.EnterString();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (IsTooShort(input))
                {
                    Message.NotLongEnough();
                }
                else
                {
                    isValidInput = true;
                }
            }
            return input;
        }

        public bool IsTooShort(string input)
        {
            return input.Length < 1;
        }

        public bool CheckIfBeginsWithALetter(string word)
        {
            return Char.IsLetter(word[0]);
        }

        public bool CheckIfBeginsWithVowel(string word)
        {
            return CheckIfVowel(word[0]);
        }

        public bool CheckIfVowel(char character)
        {
            return Regex.IsMatch(character.ToString(), "[aeiouyAEIOUY]");
        }

        public string AddYayToTheEnd(string word)
        {
            return word + "yay";
        }

        public string MoveConsonantsToTheEnd(string word)
        {
            var numConsonants = ConsonantCounter(word);
            return word.Substring(numConsonants) + word.Substring(0, numConsonants);
        }

        public int ConsonantCounter(string word)
        {
            var counter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (CheckIfVowel(word[i]) == true)
                {
                    break;
                }
                counter += 1;
            }
            return counter;
        }

        public string AddAyToTheEnd(string word)
        {
            return word + "ay";
        }

        public string TranslateToPigLatin(string userString)
        {
            var newString = "";
            var word = "";
            for (int i = 0; i < userString.Length; i++)
            {
                if (Char.IsLetter(userString[i]) || userString[i] == '\'')
                {
                    word += userString[i];
                }
                if (userString[i] == ' ' || i == userString.Length - 1)
                {
                    if (word.Length > 0)
                    {
                        if (CheckIfBeginsWithALetter(word))
                        {
                            if (CheckIfBeginsWithVowel(word))
                            {
                                word = AddYayToTheEnd(word);
                            }
                            else
                            {
                                word = MoveConsonantsToTheEnd(word);
                                word = AddAyToTheEnd(word);
                            }
                        }
                        newString = newString + word + " ";
                        word = "";
                    }
                }
            }
            if (newString[newString.Length -1] == ' ' && newString.Length > 1)
            {
                newString = newString.Substring(0, newString.Length - 1);
            }
            return newString;
        }
    }
}
