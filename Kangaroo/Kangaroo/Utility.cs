using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kangaroo_Messages;

namespace Kangaroo
{
    public class Utility
    {
        public int GetStartingDistance(string firstSecond, int firstKangarooStart)
        {
            Message.InputStartingDistance(firstSecond);
            var isValidInput = false;
            var input = "";
            while (!isValidInput)
            {
                input = Console.ReadLine();
                if (!CheckIfInt(input))
                {
                    Message.StartingDistanceNotANumber(input, firstSecond);
                }
                else
                {
                    if (!CheckIfPositive(input))
                    {
                        Message.StartingDistanceMustBePositive(firstSecond);
                    }
                    else if (!CheckIfFartherThanFirst(input, firstKangarooStart))
                    {
                        Message.SecondKangarooMustBeFarther();
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return int.Parse(input);
        }

        public int GetDistancePerJump(string firstSecond)
        {
            Message.InputJumpingDistance(firstSecond);
            var isValidInput = false;
            var input = "";
            while (!isValidInput)
            {
                input = Console.ReadLine();
                if (!CheckIfInt(input))
                {
                    Message.JumpingDistanceNotANumber(input, firstSecond);
                }
                else
                {
                    if (!CheckIfPositive(input))
                    {
                        Message.JumpingDistanceMustBePositive(firstSecond);
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

        public bool CheckIfFartherThanFirst(string input, int firstKangarooStart)
        {
            return int.Parse(input) > firstKangarooStart;
        }

        public int NumJumpsToReachSameSpot(int firstKangarooStartingPoint, int firstKangarooJumpDistance, int secondKangarooStartingPoint, int secondKangarooJumpDistance)
        {
            var firstKangarooTotalDistance = firstKangarooStartingPoint;
            var secondKangarooTotalDistance = secondKangarooStartingPoint;
            if (secondKangarooJumpDistance >= firstKangarooJumpDistance)
            {
                return -1;
            }
            var counter = 0;
            while (secondKangarooTotalDistance > firstKangarooTotalDistance)
            {
                counter++;
                secondKangarooTotalDistance += secondKangarooJumpDistance;
                firstKangarooTotalDistance += firstKangarooJumpDistance;
                if (secondKangarooTotalDistance == firstKangarooTotalDistance)
                {
                    return counter;
                }
            }
            return -1;
        }

        public int CalculateSameSpotDistance(int firstKangarooStartingPoint, int firstKangarooJumpDistance, int numJumps)
        {
            return firstKangarooStartingPoint + firstKangarooJumpDistance * numJumps;
        }
    }
}
