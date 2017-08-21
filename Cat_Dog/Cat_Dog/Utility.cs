using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cat_Dog_Messages;

namespace Cat_Dog
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
            return userInput.Length >= 3;
        }

        public int GetCount(string userString, string animal)
        {
            var count = 0;
            for (int i = 0; i < userString.Length - 2; i++)
            {
                if (userString.Substring(i, 3) == animal)
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}
