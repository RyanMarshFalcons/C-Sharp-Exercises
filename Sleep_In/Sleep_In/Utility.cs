using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sleep_In_Messages;

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
            return ((input == "A") || (input == "B") || (input == "C") || (input == "D") || (input == "E") || (input == "F") || (input == "G"));
        }

        public bool IsWeekEnd(string daySelection)
        {
            return (daySelection == "F") || (daySelection == "G");
        }

        public bool AskIfVacationDay()
        {
            var IsValidInput = false;
            var input = "";
            Message.AskIfVacationDay();
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
            if (input == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckIfyOrn(string input)
        {
            if ((input == "y") || (input == "n"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CanSleepIn(bool isWeekend, bool isVacationDay)
        {
            return isWeekend || isVacationDay;
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
