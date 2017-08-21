using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frog_Bird_Messages;

namespace Frog_Bird
{
    public class Utility
    {
        public string GetValidString()
        {
            var userInput = "";
            Message.RequestUserInput();
            var validEntry = false;
            while (validEntry == false)
            {
                userInput = Console.ReadLine();
                if (CheckIfLongEnough(userInput) == false)
                {
                    Message.NotEnoughCharacters();
                }
                else
                {
                    validEntry = true;
                }
            }
            return userInput;
        }

        public bool CheckIfLongEnough(string userInput)
        {
            return userInput.Length >= 4;
        }

        public int GetCount(string userString, string animal)
        {
            var count = 0;
            for (int i = 0; i < userString.Length - 3; i++)
            {
                if (userString.Substring(i, 4) == animal)
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}
