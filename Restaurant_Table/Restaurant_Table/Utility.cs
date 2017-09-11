using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Table_Messages;

namespace Restaurant_Table
{
    public class Utility
    {
        public int GetValidNumber(string person)
        {
            Message.HowFashionable(person);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotANumber(input, person);
                }
                else
                {
                    if (!CheckIfWithinRange(input))
                    {
                        Message.MustBeBetweenOneandTen(int.Parse(input), person);
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

        public bool CheckIfWithinRange(string input)
        {
            return int.Parse(input) > 0 && int.Parse(input) < 11;
        }

        public bool FashionableEnough(int fashionLevel)
        {
            return fashionLevel >= 8;
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
            return input == "A" || input == "B" || input == "C" || input == "D" || input == "E" || input == "F" || input == "G";
        }

        public bool IsWeekEnd(string daySelection)
        {
            return daySelection == "E" || daySelection == "F";
        }

        public bool GetTable(bool youFashionable, bool dateFashionable, bool isWeekEnd)
        {
            return (youFashionable && dateFashionable) || ((youFashionable || dateFashionable) && !isWeekEnd);
        }

        public void DisplayResults(bool gotTable)
        {
            if (gotTable)
            {
                Message.GetTheTable();
            }
            else
            {
                Message.DontGetTable();
            }
        }
    }
}
