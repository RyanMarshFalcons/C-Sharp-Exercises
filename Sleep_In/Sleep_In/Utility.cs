using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sleep_In_Messages;
using System.Text.RegularExpressions;

namespace Sleep_In
{
    public class Utility
    {
        public string GetValidEntry()
        {
            Message.SelectDayOfWeek();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (!CheckIfABCDEFG(input)) 
                {
                    Message.NotADayOfTheWeek(input);
                }
                else
                {
                    isValidInput = true;
                }
            }
            return input;
        }

        public bool CheckIfABCDEFG(string input)
        {
            return Regex.IsMatch(input, "[A-G]") && input.Length == 1;
        }

        public bool IsWeekEnd(string daySelection)
        {
            return daySelection == "F" || daySelection == "G";
        }

        public bool AskYesOrNo()
        {
            var IsValidInput = false;
            var input = "";
            
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

        public bool CanSleepIn(bool isWeekend, bool isVacationDay, bool havePlans)
        {
            return (isWeekend || isVacationDay) && !havePlans;
        }

        public void DisplayResults(bool canSleepIn)
        {
            if (canSleepIn)
            {
                Message.YesCanSleepIn();
            }
            else
            {
                Message.NoCannotSleepIn();
            }
        }
    }
}
