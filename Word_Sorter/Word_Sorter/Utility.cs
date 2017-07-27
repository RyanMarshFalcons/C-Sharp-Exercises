using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word_Sorter_Messages;

namespace Word_Sorter
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
                else if (CheckIfWord(input) == false)
                {
                    Message.NotAWord(input);
                }
                else
                {
                    isValidInput = true;
                }
            }
            return input;
        }


        public bool CheckIfWord(string input)
        {
            var isAWord = true;
            var inputAsArray = input.ToCharArray();
            foreach (var character in inputAsArray)
            {
                if (Char.IsLetter(character) == false)
                {
                    if (character != '\'')
                    {
                        isAWord = false;
                    }
                }
            }
            return isAWord;
        }


        public bool AskToContinue()
        {
            var IsValidInput = false;
            var input = "";
            Message.AddAnotherWord();
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
            if (input == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckIfyOrn(string input)
        {
            if ((input == "y") || (input == "n"))
            {
                return true;
            }
            else
            {
                return false;
            }
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
