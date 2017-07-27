using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messages;
namespace Letter_Sorter
{
    public class Utility
    {
        public char GetValidEntry()
        {
            Message.EnterLetter();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfChar(input) == false)
                {
                    Message.NotALetter(input);
                }
                else
                {
                    if (CheckIfLetter(Char.Parse(input)) == false)
                    {
                        Message.NotALetter(input);
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return Char.Parse(input);
        }

        public bool CheckIfChar(string input)
        {
            var letter = 'a';
            return Char.TryParse(input, out letter);
        }

        public bool CheckIfLetter(char input)
        {
            return Char.IsLetter(input);
        }
        

        public bool AskToContinue()
        {
            var IsValidInput = false;
            var input = "";
            Message.AddAnotherLetter();
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

        public List<char> SortTheLetters(List<char> letters)
        {
            letters.Sort();
            return letters;
        }

        public void DisplaySortedLetters(List<char> letters, int counter)
        {
            Message.LettersSortedBelow(counter);
            foreach (var letter in letters)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
