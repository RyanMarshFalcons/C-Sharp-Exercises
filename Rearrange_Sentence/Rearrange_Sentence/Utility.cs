using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rearrange_Sentence_Messages;
using System.Text.RegularExpressions;

namespace Rearrange_Sentence
{
    public class Utility
    {
        public string GetValidString()
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
            return input.Length < 10;
        }

        public string RemovePunctuation(string userString)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9' -]");
            return rgx.Replace(userString, "");
        }

        public List<string> MakeListOfWords(string userString)
        {
            var words = new List<string>();
            var word = "";
            for (int i = 0; i < userString.Length; i++)
            {
                if (userString[i] != ' ')
                {
                    word += userString[i];
                }
                if ((userString[i] == ' ' || i == userString.Length - 1) && word.Length > 0)
                {
                    words.Add(word);
                    word = "";
                }
            }
            return words;
        }

        public List<string> RandomizeWords(List<string> words)
        {
            var randomizedWords = new List<string>();
            var random = new Random();
            while (words.Count > 0)
            {
                var index = random.Next(0, words.Count);
                randomizedWords.Add(words[index]);
                words.RemoveAt(index);
            }
            return randomizedWords;
        }

        public string FormNewSentence(List<string> randomizedWords)
        {
            var newSentence = "";
            foreach (var word in randomizedWords)
            {
                newSentence += (word + " ");
            }
            if (newSentence.Length > 1)
            {
                newSentence = newSentence[0].ToString().ToUpper() + newSentence.Substring(1);
                return newSentence.Substring(0, newSentence.Length - 1) + ".";
            }
            else
            {
                return "an empty string";
            }
        }
    }
}
