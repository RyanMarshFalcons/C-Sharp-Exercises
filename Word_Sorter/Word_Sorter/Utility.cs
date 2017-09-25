using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Word_Sorter_Messages;

namespace Word_Sorter
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

        public string RemoveNumsAndSymbols(string userString)
        {
            return Regex.Replace(userString, "[^a-zA-Z' ]", "");
        }

        public List<string> ExtractWords(string modifiedUserString)
        {
            var listOfWords = new List<string>();
            var word = "";
            for (int i = 0; i < modifiedUserString.Length; i++)
            {
                if (Char.IsLetter(modifiedUserString[i]) || modifiedUserString[i] == '\'')
                {
                    word += modifiedUserString[i];
                }
                else
                {
                    if (word.Length > 0)
                    {
                        listOfWords.Add(word);
                        word = "";
                    }
                }
            }
            if (word.Length > 0)
            {
                listOfWords.Add(word);
            }
            return listOfWords;
        }

        public List<string> SortTheWords(List<string> words)
        {
            words.Sort();
            return words;
        }

        public void DisplaySortedWords(List<string> words, int counter)
        {
            Message.WordsSortedBelow(counter);
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
