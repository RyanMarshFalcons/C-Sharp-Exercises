﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Remove_Characters_Messages;

namespace Remove_Characters
{
    public class Utility
    {
        public string GetValidString()
        {
            var userInput = "";
            Message.EnterString();
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
                    validInput = true;
                }
            }
            return userInput;
        }

        public bool IsTooShort(string input)
        {
            return input.Length < 1;
        }

        public char GetValidChar()
        {
            var input = "";
            var validInput = false;
            Message.EnterCharacter();
            while (validInput == false)
            {
                input = Console.ReadLine();
                if (IsASingleCharacter(input) == false)
                {
                    Message.NotACharacter(input);
                }
                else
                {
                    validInput = true;
                }
            }
            return Char.Parse(input);
        }

        public bool IsASingleCharacter(string input)
        {
            return input.Length == 1;
        }

        public string RemoveCharacter(string userString, char character)
        {
            string end = "";
            for (int i = userString.Length - 1; i > -1; i--)
            {
                if (userString[i] == character)
                {
                    if (i != userString.Length - 1)
                    {
                        end = userString.Substring(i + 1);
                    }
                    userString = userString.Substring(0, i) + end;
                }
            }
            return userString;
        }

        public bool AskToContinue(int userStringLength)
        {
            if (userStringLength == 0)
            {
                Message.StringIsEmpty();
                return false;
            }
            var IsValidInput = false;
            var input = "";
            Message.RemoveAnotherCharacter();
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
