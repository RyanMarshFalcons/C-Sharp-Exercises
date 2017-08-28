using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max_Block_Messages;

namespace Max_Block
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
                    Message.NotLongEnough();
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
            return input.Length < 1;
        }

        public int FindLongestBlock(string userString)
        {
            var counter = 0;
            var placeHolder = 0;
            while (userString.Length > 0)
            {
                counter = 0;
                for (int i = 0; i < userString.Length; i++)
                {
                    if (userString[0] == userString[i])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (counter > placeHolder)
                {
                    placeHolder = counter;
                }
                userString = userString.Substring(counter);
            }
            return placeHolder;
        }
    }
}
