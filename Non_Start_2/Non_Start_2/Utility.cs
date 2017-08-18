using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Non_Start_2_Messages;

namespace Non_Start_2
{
    public class Utility
    {
        public string GetValidString(int stringNum)
        {
            var userInput = "";
            var validInput = false;
            Message.RequestUserInput(stringNum);
            while (validInput == false)
            {
                userInput = Console.ReadLine();
                if (CheckIfTooShort(userInput))
                {
                    Message.MustBeAtLeast1Character();
                }
                else
                {
                    validInput = true;
                }
            }
            return userInput;
        }

        public bool CheckIfTooShort(string userInput)
        {
            return userInput.Length < 1;
        }

        public string MakeNewString(string userString1, string userString2)
        {
            return userString1.Substring(1, userString1.Length - 1) + userString2.Substring(1, userString2.Length - 1);
        }
    }
}
