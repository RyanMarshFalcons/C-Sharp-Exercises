using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Front_Again_1_Messages;

namespace Front_Again_1
{
    public class Utility
    {
        public string GetValidString()
        {
            var userInput = "";
            var validEntry = false;
            Message.RequestString();
            while (validEntry == false)
            {
                userInput = Console.ReadLine();
                if (!CheckIfLongEnough(userInput))
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

        public bool CheckIfLongEnough(string input)
        {
            return input.Length >= 2;
        }

        public string GetBegining(string userString)
        {
            return userString.Substring(0, 1);
        }

        public string GetEnding(string userString)
        {
            return userString.Substring(userString.Length - 1);
        }

        public void DisplayResults(string begining, string ending)
        {
            if (begining == ending)
            {
                Message.DoMatch(begining);
            }
            else
            {
                Message.DontMatch(begining, ending);
            }
        }
    }
}
