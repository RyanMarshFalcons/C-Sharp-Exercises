using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insert_Character_Messages;

namespace Insert_Character
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

        public string GetCharacter()
        {
            var userInput = "";
            Message.EnterCharacter();
            while (userInput.Length != 1)
            {
                userInput = Console.ReadLine();
                if (userInput == "")
                {
                    Message.NotACharacter(userInput);
                }
            }
            return userInput;
        }


        public int GetIndex(int lengthOfString, string userCharacter)
        {
            Message.EnterIndex(userCharacter);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (!CheckIfInt(input))
                {
                    Message.NotANumber(input);
                }
                else
                {
                    if (CheckIfNegative(input))
                    {
                        Message.CannotBeNegative();
                    }
                    else
                    {
                        if (!CheckIfIndexExists(input, lengthOfString))
                        {
                            Message.NotAValidIndex(input, lengthOfString);
                        }
                        else
                        {
                            isValidInput = true;
                        }
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

        public bool CheckIfNegative(string input)
        {
            return Int32.Parse(input) < 0;
        }

        public bool CheckIfIndexExists(string input, int lengthOfString)
        {
            return (Int32.Parse(input) + 1) <= lengthOfString;
        }

        public string GetNewString(string userString, int index, string userChar)
        {
            var beginning = userString.Substring(0, index);
            var ending = userString.Substring(index, userString.Length - index);
            return beginning + userChar + ending;
        }
    }
}
