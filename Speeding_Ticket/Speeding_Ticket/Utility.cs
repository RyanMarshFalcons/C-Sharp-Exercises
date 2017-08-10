using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Speeding_Ticket_Messages;

namespace Speeding_Ticket
{
    public class Utility
    {
        public int GetValidEntry()
        {
            Message.EnterNumber();
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
                    if (int.Parse(input) < 56)
                    {
                        Message.Lying();
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

        public int GetmphOver(int speed)
        {
            return speed - 55;
        }

        public void DisplayResults(int mphOver)
        {
            if (mphOver > 40)
            {
                Message.FortyOneOrMore(mphOver);
            }
            else if (mphOver > 30)
            {
                Message.ThirtyOneToForty(mphOver);
            }
            else if (mphOver > 23)
            {
                Message.TwentyFourToThirty(mphOver);
            }
            else if (mphOver > 18)
            {
                Message.NineteenToTwentyThree(mphOver);
            }
            else if (mphOver > 10)
            {
                Message.ElevenToEighteen(mphOver);
            }
            else if (mphOver > 4)
            {
                Message.FiveToTen(mphOver);
            }
            else
            {
                Message.LessThanFive(mphOver);
            }
        }
    }
}