using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoveDuplicateLetters_Messages;

namespace RemoveDuplicateLetters
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

        public List<char> RemoveDuplicates(List<char> originalList)
        {
            return originalList.Distinct().ToList();
        }

        public void DisplayNewList(List<char> newList, int lettersRemoved)
        {
            Message.NewListBelow(lettersRemoved);
            foreach (var letter in newList)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
