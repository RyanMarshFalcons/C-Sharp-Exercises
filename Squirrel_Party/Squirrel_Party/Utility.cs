using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Squirrel_Party_Messages;
using System.Text.RegularExpressions;

namespace Squirrel_Party
{
    public class Utility
    {
        public int GetValidNumber(string sodasNuts)
        {
            Message.HowManySodasNuts(sodasNuts);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotANumber(input);
                }
                else
                {
                    if (CheckIfNegative(input))
                    {
                        Message.CantBeNegative(sodasNuts);
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return int.Parse(input);
        }

        public bool CheckIfInt(string input)
        {
            var num = 0;
            return int.TryParse(input, out num);
        }

        public bool CheckIfNegative(string input)
        {
            return int.Parse(input) < 0;
        }

        public bool EnoughNuts(int numNuts)
        {
            return numNuts >= 50;
        }

        public bool EnoughSodas(int numSodas)
        {
            return numSodas >= 30;
        }

        public string GetValidDay()
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

        public bool IsSuccessful(bool enoughNuts, bool enoughSodas, bool isWeekEnd)
        {
            return (enoughNuts && enoughSodas) || isWeekEnd;
        }

        public void DisplayResults(bool isSuccesful)
        {
            if (isSuccesful)
            {
                Message.PartyWillBeSuccessful();
            }
            else
            {
                Message.PartyWillBeAFailure();
            }
        }
    }
}
