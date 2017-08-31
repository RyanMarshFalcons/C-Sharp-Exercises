using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Replace_Characters_Messages;

namespace Replace_Characters
{
    public class Utility
    {
        public string GetString()
        {
            var userInput = "";
            Message.EnterString();
            while (userInput == "")
            {
                userInput = Console.ReadLine();
                if (userInput == "")
                {
                    Message.NoEmptyStrings();
                }
            }
            return userInput;
        }

        public int GetMaxIndex(string userString)
        {
            return userString.Length - 1;
        }

        public char GetCharacter()
        {
            var userInput = "";
            Message.EnterCharacter();
            while (userInput.Length != 1)
            {
                userInput = Console.ReadLine();
                if (userInput.Length != 1)
                {
                    Message.NotACharacter(userInput);
                }
            }
            return Char.Parse(userInput);
        }

        public int GetIndex(int maxIndex, char userCharacter)
        {
            Message.EnterIndex(userCharacter);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (!CheckIfInt(input))
                {
                    Message.NotANumber(input, userCharacter);
                }
                else
                {
                    if (!CheckIfIndexExists(input, maxIndex))
                    {
                        Message.NotAValidIndex(input, maxIndex, userCharacter);
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return Int32.Parse(input);
        }

        public bool CheckIfInt(string input)
        {
            var num = 0;
            return Int32.TryParse(input, out num);
        }

        public bool CheckIfIndexExists(string input, int maxIndex)
        {
            return Int32.Parse(input) >=0 && int.Parse(input) <= maxIndex;
        }

        public string GetNewString(string userString, int index, char userChar)
        {
            var beginning = userString.Substring(0, index);
            var ending = "";
            if (index != userString.Length - 1)
            {
                ending = userString.Substring(index + 1);
            }
            return beginning + userChar + ending;
        }

        public bool AskToContinue()
        {
            var IsValidInput = false;
            var input = "";
            Message.ReplaceAnotherCharacter();
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
            return input == "y";
        }

        public bool CheckIfyOrn(string input)
        {
            return input == "y" || input == "n";
        }
    }
}
