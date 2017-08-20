﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Index_Four_Chars_Messages;

namespace Index_Four_Chars
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
                    Message.AtLeastFourCharacters();
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
            return input.Length >= 4;
        }

        public int GetMaxIndex(string userString)
        {
            return userString.Length - 4;
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
                    Message.NotANumber(input);
                }
                else
                {
                    if (IsInRange(input, maxIndex) == false)
                    {
                        Message.OutOfRange(input, maxIndex);
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

        public bool IsInRange(string input, int maxIndex)
        {
            return (int.Parse(input) <= maxIndex) && (int.Parse(input) >= 0);
        }

        public string CreateNewString(string userString, int index)
        {
            return userString.Substring(index, 4);
        }
    }
}
