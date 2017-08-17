using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Int_Min_3_Messages;

namespace Int_Min_3
{
    public class Utility
    {
        public int GetValidNumber(string entryNum)
        {
            Message.EnterNumber(entryNum);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotANumber(input, entryNum);
                }
                else
                {
                    isValidInput = true;
                }
            }
            return Int32.Parse(input);
        }

        public bool CheckIfInt(string input)
        {
            var num = 0;
            return Int32.TryParse(input, out num);
        }

        public int GetMin(int num1, int num2, int num3)
        {
            var min = Math.Min(num1, num2);
            return Math.Min(min, num3);
        }
    }
}
