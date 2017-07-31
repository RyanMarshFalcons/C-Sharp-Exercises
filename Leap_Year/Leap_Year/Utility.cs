using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leap_Year_Messages;

namespace Leap_Year
{
    public class Utility
    {
        public int GetValidEntry()
        {
            Message.EnterYear();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfYear(input) == false)
                {
                    Message.NotAYear(input);
                }
                else
                {
                    isValidInput = true;
                }
            }
            return Int32.Parse(input);
        }

        public bool CheckIfYear(string input)
        {
            var num = 0;
            return Int32.TryParse(input, out num);
        }

        public bool CheckIfLeapYear(int num)
        {
            return num % 4 == 0;
        }
    }
}
