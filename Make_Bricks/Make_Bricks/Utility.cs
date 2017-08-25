using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Make_Bricks_Messages;

namespace Make_Bricks
{
    public class Utility
    {
        public int GetValidLength()
        {
            Message.RowLength();
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
                    if (CheckIfLongEnough(input) == false)
                    {
                        Message.MustHavePositiveLength();
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

        public bool CheckIfLongEnough(string input)
        {
            return int.Parse(input) > 0;
        }

        public int GetNumBricks(string brickType)
        {
            Message.NumberOfBricks(brickType);
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
                    if (CheckIfValidNum(input) == false)
                    {
                        Message.CantBeNegativeNum(brickType);
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return int.Parse(input);
        }

        public bool CheckIfValidNum(string input)
        {
            return int.Parse(input) >= 0;
        }

        public bool CheckIfPossible(int rowLength, int numSmall, int numMedium, int numLarge)
        {
            while (rowLength >= 5 && numLarge > 0)
            {
                rowLength -= 5;
                numLarge -= 1;
            }
            while (rowLength >= 3 && numMedium > 0)
            {
                rowLength -= 3;
                numMedium -= 1;
            }
            while (rowLength >= 1 && numSmall > 0)
            {
                rowLength -= 1;
                numSmall -= 1;
            }
            return rowLength == 0;
        }

        public void DisplayResults(bool isPossible, int rowLength)
        {
            if (isPossible)
            {
                Message.HaveEnoughBricks(rowLength);
            }
            else
            {
                Message.DontHaveEnoughBricks(rowLength);
            }
        }
    }
}
