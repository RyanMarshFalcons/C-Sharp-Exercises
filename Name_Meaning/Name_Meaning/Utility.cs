using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Name_Meaning_Messages;

namespace Name_Meaning
{
    public class Utility
    {
        public string GetUsersName()
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
                    if (ContainsALetter(userInput) == false)
                    {
                        Message.DoesNotContainLetter();
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
            return input.Length < 1;
        }

        public bool ContainsALetter(string input)
        {
            var containsLetter = false;
            foreach (var character in input)
            {
                if (Char.IsLetter(character))
                {
                    containsLetter = true;
                }
            }
            return containsLetter;
        }

        public string GetJustLetters(string userName)
        {
            var newString = "";
            foreach (var character in userName)
            {
                if (Char.IsLetter(character))
                {
                    newString += character;
                }
            }
            return newString.ToUpper();
        }

        public Dictionary<char, string> GetAdjectiveDictionary()
        {
            return new Dictionary<char, string>()
            {
                { 'A', "Adventurous" },
                { 'B', "Benevolent" },
                { 'C', "Caring" },
                { 'D', "Determined" },
                { 'E', "Enthusiastic" },
                { 'F', "Funny" },
                { 'G', "Generous" },
                { 'H', "Honest" },
                { 'I', "Intelligent" },
                { 'J', "Joyful" },
                { 'K', "Kind" },
                { 'L', "Loving" },
                { 'M', "Magananimous" },
                { 'N', "Noble" },
                { 'O', "Outgoing" },
                { 'P', "Personable" },
                { 'Q', "Quixotic" },
                { 'R', "Respectful" },
                { 'S', "Selfless" },
                { 'T', "Thoughtful" },
                { 'U', "Unimpeachable" },
                { 'V', "Versatile" },
                { 'W', "Wonderful" },
                { 'X', "Xenodochial" },
                { 'Y', "Youthful" },
                { 'Z', "Zealous" },
            };
        }

        public List<string> GetDescription(string modifiedUserName, Dictionary<char, string> definitions)
        {
            var description = new List<string>();
            for (int i = 0; i < modifiedUserName.Length; i++)
            {
                description.Add(definitions[modifiedUserName[i]]);
            }
            return description;
        }
    }
}
