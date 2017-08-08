using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exponent_Messages;

namespace Exponent
{
    public class Utility
    {
        public int GetValidEntry(string BaseOrExpoent)
        {
            Message.EnterNumber(BaseOrExpoent);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotANumber(input, BaseOrExpoent);
                }
                else
                {
                    if (CheckIfPositive(input) == false)
                    {
                        Message.MustBePositive(input, BaseOrExpoent);
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return Int32.Parse(input);
        }

        public bool CheckIfInt(string input)
        {
            var num = 0;
            return Int32.TryParse(input, out num);
        }

        public bool CheckIfPositive(string input)
        {
            return Int32.Parse(input) > 0;
        }

        public int GetProduct(int Base, int Exponent)
        {
            var product = Base;
            for (int i = 1; i < Exponent; i++)
            {
                product *= Base;
            }
            return product;
        }
    }
}
