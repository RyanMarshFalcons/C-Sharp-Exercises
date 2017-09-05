using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals_Messages;

namespace Animals
{
    class Utility
    {
        public bool AskToContinue()
        {
            var IsValidInput = false;
            var input = "";
            Message.AddAnotherAnimal();
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
