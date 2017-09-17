using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grains_Messages;

namespace Grains
{
    public class Utility
    {
        public int GetNumberOfSquares()
        {
            Message.InputNumber();
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
                    if (CheckIfPositive(input) == false)
                    {
                        Message.MustBePositive();
                    }
                    else if (CheckIfMoreThan64(input))
                    {
                        Message.CannotBeGreaterThan64();
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

        public bool CheckIfPositive(string input)
        {
            return int.Parse(input) > 0;
        }

        public bool CheckIfMoreThan64(string input)
        {
            return int.Parse(input) > 64;
        }

        public ulong CalculateGrains(int numberOfSquares)
        {
            Console.WriteLine();
            var sum = 0UL;
            var grains = 1UL;
            var grainsAsString = "";
            for (int i = 1; i < numberOfSquares + 1; i++)
            {
                grainsAsString = AddCommasToNumber(grains);
                Console.WriteLine($"Square {i}: {grainsAsString} grains of wheat");
                sum += grains;
                grains *= 2;
            }
            return sum;
        }

        public string AddCommasToNumber(ulong numGrains)
        {
            return String.Format("{0:n0}", numGrains);
        }
    }
}
