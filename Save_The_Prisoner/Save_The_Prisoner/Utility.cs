using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Save_The_Prisoner_Messages;

namespace Save_The_Prisoner
{
    public class Utility
    {
        public int GetNumberOfPrisoners()
        {
            Message.EnterNumberOfPrisoners();
            var isValidInput = false;
            var input = "";
            while (!isValidInput)
            {
                input = Console.ReadLine();
                if (!CheckIfInt(input))
                {
                    Message.NumberOfPrisonersNotANumber(input);
                }
                else
                {
                    if (!CheckIfAtLeastTwo(input))
                    {
                        Message.LessThanTwoPrisoners();
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return int.Parse(input);
        }

        public int GetIDOfPrisonerGettingFirstSweet(int NumberOfPrisoners)
        {
            Message.EnterIDOfFirstPrisoner();
            var isValidInput = false;
            var input = "";
            while (!isValidInput)
            {
                input = Console.ReadLine();
                if (!CheckIfInt(input))
                {
                    Message.PrisonerIDIsNotANumber(input);
                }
                else
                {
                    if (!CheckIfAtLeastOne(input))
                    {
                        Message.IDOfFirstPrisonerIsLessThanOne();
                    }
                    else if (CheckIfIDIsGreaterThanNumPrisoners(input, NumberOfPrisoners))
                    {
                        Message.IDOfFirstPrisonerExceedsNumberOfPrisoners();
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return int.Parse(input);
        }

        public int GetNumberOfSweets()
        {
            Message.EnterNumberOfSweets();
            var isValidInput = false;
            var input = "";
            while (!isValidInput)
            {
                input = Console.ReadLine();
                if (!CheckIfInt(input))
                {
                    Message.NumberOfSweetssNotANumber(input);
                }
                else
                {
                    if (!CheckIfAtLeastOne(input))
                    {
                        Message.LessThanOneSweet();
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

        public bool CheckIfAtLeastOne(string input)
        {
            return int.Parse(input) >= 1;
        }

        public bool CheckIfAtLeastTwo(string input)
        {
            return int.Parse(input) >= 2;
        }

        public bool CheckIfIDIsGreaterThanNumPrisoners(string input, int NumberOfPrisoners)
        {
            return int.Parse(input) > NumberOfPrisoners;
        }

        public int CalculateIDOfPrisonerToWarn(int numberOfPrisoners, int IDOfPrisonerWhoGetsFirstSweet, int numberOfSweets)
        {
            if (numberOfSweets + IDOfPrisonerWhoGetsFirstSweet - 1 < numberOfPrisoners)
            {
                return numberOfSweets + IDOfPrisonerWhoGetsFirstSweet - 1;
            }
            while (numberOfSweets + IDOfPrisonerWhoGetsFirstSweet - 1 > numberOfPrisoners)
            {
                numberOfSweets -= numberOfPrisoners;
            }
            return numberOfSweets + IDOfPrisonerWhoGetsFirstSweet - 1;
        }
    }
}
