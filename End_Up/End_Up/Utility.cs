using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using End_Up_Messages;

namespace End_Up
{
    public class Utility
    {
        public string GetString()
        {
            var userInput = "";
            var validEntry = false;
            Message.RequestUserInput();
            while (!validEntry)
            {
                userInput = Console.ReadLine();
                if (CheckIfTooShort(userInput))
                {
                    Message.AtLeastThreeCharacters();
                }
                else
                {
                    validEntry = true;
                }
            }
            return userInput;
        }

        public bool CheckIfTooShort(string input)
        {
            return input.Length < 3;
        }

        public string MakeEndUpperCase (string userString)
        {
            var end = (userString.Substring(userString.Length - 3, 3)).ToUpper();
            var rest = userString.Substring(0, userString.Length - 3);
            return rest + end;
        }
    }
}
