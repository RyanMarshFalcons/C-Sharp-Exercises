using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosine_Messages;

namespace Cosine
{
    public class Utility
    {
        public double GetValidEntry()
        {
            Message.EnterNumber();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfDouble(input) == false)
                {
                    Message.NotANumber(input);
                }
                else
                {
                    isValidInput = true;
                }
            }
            return Double.Parse(input);
        }

        public bool CheckIfDouble(string input)
        {
            var num = 0.0;
            return Double.TryParse(input, out num);
        }

        public double GetCosine(double num)
        {
            return Math.Round(Math.Cos(num), 2);
        }
    }
}
