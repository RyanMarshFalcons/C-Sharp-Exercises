using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Int_Max_4_Messages;

namespace Int_Max_4
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

        public int GetMax(int num1, int num2, int num3, int num4)
        {
            var max = Math.Max(num1, num2);
            max = Math.Max(max, num3);
            return Math.Max(max, num4);
        }
    }
}
