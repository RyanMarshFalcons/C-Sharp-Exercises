﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Without_Z_Messages;

namespace Without_Z
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
                    Message.AtLeastOneCharacter();
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

        public string CreateNewString(string userString)
        {
            while ((userString.IndexOf('z') == 0) || (userString.IndexOf('Z') == 0))
            {
                if (userString.Length == 1)
                {
                    return "an empty string";
                }
                else
                {
                    userString = userString.Substring(1, userString.Length - 1);
                }
            }
            while ((userString.LastIndexOf('z') == userString.Length - 1) || (userString.LastIndexOf('Z') == userString.Length - 1))
            {
                userString = userString.Substring(0, userString.Length - 1);
            }
            return userString;
        }
    }
}
