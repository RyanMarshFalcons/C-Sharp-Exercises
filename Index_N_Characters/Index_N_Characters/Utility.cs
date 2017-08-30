using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Index_N_Characters_Messages;

namespace Index_N_Characters
{
    public class Utility
    {
        public string GetString()
        {
            var isValid = false;
            var userInput = "";
            Message.EnterString();
            while (isValid == false)
            {
                userInput = Console.ReadLine();
                if (!CheckIfValidString(userInput))
                {
                    Message.TooShort();
                }
                else
                {
                    isValid = true;
                }
            }
            return userInput;
        }

        public bool CheckIfValidString(string input)
        {
            return input.Length >= 1;
        }

        public int GetMaxIndex(string userString)
        {
            return userString.Length - 1;
        }

        public int GetValidIndex(int maxIndex)
        {
            Message.EnterIndex();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotAValidIndex(input);
                }
                else
                {
                    if (IndexIsInRange(input, maxIndex) == false)
                    {
                        Message.IndexOutOfRange(input, maxIndex);
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return int.Parse(input);
        }

        public bool CheckIfInt(string input)
        {
            var num = 0;
            return int.TryParse(input, out num);
        }

        public bool IndexIsInRange(string input, int maxIndex)
        {
            return (int.Parse(input) <= maxIndex) && (int.Parse(input) >= 0);
        }

        public int GetMaxNumChars(string userString, int index)
        {
            return userString.Length - index;
        }

        public int GetValidNumChars(int maxNumChars)
        {
            Message.EnterNumberCharacters();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotAValidNumChars(input);
                }
                else
                {
                    if (NumCharsIsInRange(input, maxNumChars) == false)
                    {
                        Message.NumCharsOutOfRange(input, maxNumChars);
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return int.Parse(input);
        }

        public bool NumCharsIsInRange(string input, int maxNumChars)
        {
            return (int.Parse(input) <= maxNumChars) && (int.Parse(input) >= 1);
        }

        public string CreateNewString(string userString, int index, int numChars)
        {
            return userString.Substring(index, numChars);
        }
    }
}
